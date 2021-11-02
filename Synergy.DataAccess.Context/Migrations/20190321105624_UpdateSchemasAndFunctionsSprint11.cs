using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class UpdateSchemasAndFunctionsSprint11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sqlStageScript = @"
                /* create needed extensions  */
                CREATE EXTENSION IF NOT EXISTS ""uuid-ossp"";

                /* create stage schema */
                CREATE SCHEMA IF NOT EXISTS stage;

                /* drop stage.property_source_data table   */
                DROP TABLE IF EXISTS stage.synergy_source_data;

                /* create stage.property_source_data table */
                CREATE TABLE stage.synergy_source_data (
	                id numeric(18) NOT NULL,
	                /* Event Info */
	                event_batch_id text NULL,
	
	                /* Lead/Owner Info */
	                lead_bk varchar(64) NULL,
	                account_name text NULL,
	                mailing_address_1 text NULL,
	                mailing_address_2 text NULL,
	                mailing_address_3 text NULL,
	                mailing_city text NULL,
	                mailing_state text NULL,
	                mailing_zip_code text NULL,
	                do_not_contact bool NULL,
	
	                /* Property Info */
	                property_bk varchar(64) NULL,
	                county_jurisdiction text NULL,
	                county_id int NULL,
	                parcel_id text NULL,
	                cad_id text NULL,
	                tax_id text NULL,
	                folio_id text NULL,
	                property_address text NULL,
	                property_city text NULL,
	                property_state text NULL,
	                property_state_id int NULL,
	                property_zip_code text NULL,
	                legal_description text NULL,
	                land_state_code text NULL,
	                improvement_state_code text NULL,
	                land_use_code text NULL,
	                internal_land_use_code text NULL,
	                general_land_use_code text NULL,
	                over_65_surviving_spouse bool NULL,
	                disability_exemption bool NULL,
	                mortgage bool NULL,
	                payment_plan bool NULL,
	                veteran bool NULL,
	                bankruptcy bool NULL,
	                third_party_foreclosure bool NULL,
	                land_acres float8 NULL,
	                building_sq_ft int4 NULL,
	                year_built int2 NULL,
	                latitude float8 NULL,
	                longitude float8 NULL,
	                homestead bool NULL,
	                ru_amount numeric(19,4) NULL,
	                ru_ltv_percent numeric(7,4) NULL,
	                ltv_percent numeric(7,4) NULL,
	
	                /* Property Valuations */
	                appraised_year int2 NULL,
	                land_value numeric(19,4) NULL,
	                improvement_value numeric(19,4) NULL,
	                appraised_value numeric(19,4) NULL,
	
	                /* Tax Delinquency */
	                delinquency_tax_year int2 NULL,
	                collecting_entity text NULL,
	                amount_due numeric(19,4) NULL,
	
	                /* Property Supplemental Event Data */
	                last_sale_date date NULL,
	                last_sale_amount numeric(19,4) NULL,
	                mortgage_lender_1 text NULL,
	                mortgage_loan_amount_1 numeric(19,4) NULL,
	                mortgage_origination_date_1 date NULL,
	                mortgage_maturity_date_1 date NULL,
	                mortgage_lender_2 text NULL,
	                mortgage_loan_amount_2 numeric(19,4) NULL,
	                mortgage_origination_date_2 date NULL,
	                mortgage_maturity_date_2 date NULL,
	                inspector_comment text NULL,
	                inspector_property_rating numeric(2,1) NULL,
	                inspector_area_rating numeric(2,1) NULL,
	                inspector_occupied bool NULL,
	                inspector_roof_condition text NULL,
	                inspector_lawn_maintained text NULL,
	                open_liens int2 NULL,
	                closed_liens int2 NULL,
	                recent_buyer_name text NULL,
	                recent_buyer_rate numeric(7,4) NULL,
	                advertisement_batch text NULL,
	                advertisement_number text NULL,
	                assessor_url text NULL,
	                treasurer_url text NULL,
	                CONSTRAINT pk_synergy_source_data PRIMARY KEY (id)
                );

                CREATE INDEX idx_synergy_source_data_lead_bk ON stage.synergy_source_data USING btree (lead_bk);
                CREATE INDEX idx_synergy_source_data_property_bk ON stage.synergy_source_data USING btree (property_bk);


                /* DROP load_main_lead FUNCTION */
                DROP FUNCTION IF EXISTS stage.load_main_lead();
                /* CREATE load_main_lead FUNCTION */
                CREATE OR REPLACE FUNCTION stage.load_main_lead()
                 RETURNS TABLE(updated_count numeric, inserted_count numeric)
                 LANGUAGE plpgsql
                AS $function$
	                DECLARE 
		                p_system_user_id UUID;
		                p_ucnt numeric;
		                p_icnt numeric;
                BEGIN

	                p_system_user_id = '00000000-0000-0000-0000-000000000001';

	                /* Update existing Lead */
	                WITH lead AS
	                (
		                SELECT DISTINCT lead_bk, mailing_city, s.""Id"" as mailing_state_id, mailing_zip_code, do_not_contact,
			                ROW_NUMBER() OVER(PARTITION BY lead_bk ORDER BY lead_bk) AS rn
		                FROM stage.synergy_source_data psd
			                LEFT JOIN main.""State"" s ON s.""Abbreviation"" = psd.mailing_state
		                WHERE lead_bk IS NOT NULL
			                AND ( psd.mailing_city IS NOT NULL
					                OR s.""Id"" IS NOT NULL
					                OR mailing_zip_code IS NOT NULL
					                OR do_not_contact IS NOT NULL)
	                )
	                UPDATE main.""Lead"" l SET 
			                ""MailingCity"" = COALESCE(lead.mailing_city, l.""MailingCity""),
			                ""MailingStateId"" = COALESCE(lead.mailing_state_id, l.""MailingStateId""),
			                ""MailingZipCode"" = COALESCE(lead.mailing_zip_code, l.""MailingZipCode""),				  
			                ""DoNotContact"" = COALESCE(lead.do_not_contact, l.""DoNotContact""),
			                ""ModifiedOn"" = LOCALTIMESTAMP,
			                ""ModifiedById"" = p_system_user_id
	                FROM lead
	                WHERE lead.rn = 1
		                AND l.""LeadBK"" = lead.lead_bk
		                AND (l.""MailingCity"" IS DISTINCT FROM COALESCE(lead.mailing_city, l.""MailingCity"")
			                 OR l.""MailingStateId"" IS DISTINCT FROM COALESCE(lead.mailing_state_id, l.""MailingStateId"")
			                 OR l.""MailingZipCode"" IS DISTINCT FROM COALESCE(lead.mailing_zip_code, l.""MailingZipCode"")
			                 OR l.""DoNotContact"" IS DISTINCT FROM COALESCE(lead.do_not_contact, l.""DoNotContact""));
	
	                GET DIAGNOSTICS p_ucnt = ROW_COUNT;

	                /* Insert new Lead */
	                WITH appv AS 
		                (
			                SELECT lead_bk,
				                appraised_value,
				                ROW_NUMBER() OVER(PARTITION BY lead_bk, property_bk ORDER BY lead_bk, property_bk, appraised_year desc) AS rn
			                FROM stage.synergy_source_data psd
			                WHERE lead_bk IS NOT NULL
		                ),
	                appv_total AS 
		                (
			                SELECT lead_bk, SUM(appraised_value) AS appraised_value 
			                FROM appv 
			                WHERE rn = 1 
			                GROUP BY lead_bk  
		                ),
	                lead AS
		                (
			                SELECT psd.lead_bk, account_name, mailing_address_1, mailing_address_2, mailing_address_3, mailing_city, 
				                s.""Id"" as mailing_state_id, mailing_zip_code, COALESCE(do_not_contact, false) as do_not_contact,
				                appv_total.appraised_value,
				                SUM(amount_due) OVER(PARTITION BY psd.lead_bk ORDER BY psd.lead_bk) AS total_amount_due_properties,
				                ROW_NUMBER() OVER(PARTITION BY psd.lead_bk ORDER BY psd.lead_bk) AS rn
			                FROM stage.synergy_source_data psd
				                INNER JOIN appv_total ON psd.lead_bk = appv_total.lead_bk
				                LEFT JOIN main.""State"" s ON s.""Abbreviation"" = psd.mailing_state
		                )
	                INSERT INTO main.""Lead""(""Id"", ""LeadBK"", ""AccountName"", ""MailingAddress1"", ""MailingAddress2"", ""MailingAddress3"", ""MailingCity"", ""MailingStateId"", 
							                ""MailingZipCode"", ""DoNotContact"", ""TotalAmountDueProperties"", ""AppraisedValueOfProperties"",
							                ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")								 
	                SELECT uuid_generate_v4() as id, lead.lead_bk, lead.account_name, lead.mailing_address_1, lead.mailing_address_2, lead.mailing_address_3,
			                lead.mailing_city, lead.mailing_state_id, lead.mailing_zip_code, lead.do_not_contact, total_amount_due_properties, appraised_value,
			                LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
	                FROM lead
	                WHERE lead.rn = 1
		                AND NOT EXISTS ( SELECT 1 FROM main.""Lead"" l WHERE l.""LeadBK"" = lead.lead_bk);
											 
	                GET DIAGNOSTICS p_icnt = ROW_COUNT;
							  
	                RETURN QUERY
	                SELECT COALESCE(p_ucnt, 0), COALESCE(p_icnt, 0);
											 
                END;
                $function$;



                /* DROP load_main_property FUNCTION */
                DROP FUNCTION IF EXISTS stage.load_main_property();
                /* CREATE load_main_property FUNCTION */
                CREATE OR REPLACE FUNCTION stage.load_main_property()
                 RETURNS TABLE(updated_count numeric, inserted_count numeric)
                 LANGUAGE plpgsql
                AS $function$
                DECLARE 
	                p_system_user_id UUID;
	                p_unknown_general_land_use_code_id smallint;
	                p_ucnt numeric;
	                p_icnt numeric;
                BEGIN

	                p_system_user_id = '00000000-0000-0000-0000-000000000001';

	                SELECT ""Id"" INTO p_unknown_general_land_use_code_id FROM main.""GeneralLandUseCode"" WHERE ""Name"" = 'Unknown';

	                /* Update existing Property */
	                WITH pr AS
	                (
		                SELECT property_bk, l.""Id"" as lead_id, parcel_id, cad_id, tax_id, folio_id, 
			                property_address, property_city, property_zip_code, legal_description, 
			                land_state_code, improvement_state_code, land_use_code, iluc.""Id"" as internal_land_use_code_id,
			                COALESCE(gluc.""Id"", p_unknown_general_land_use_code_id) as general_land_use_code_id, over_65_surviving_spouse, disability_exemption, mortgage, 
			                payment_plan, veteran, bankruptcy, third_party_foreclosure, land_acres, building_sq_ft, 
			                year_built, latitude, longitude, homestead, ru_amount, ru_ltv_percent, ltv_percent,
			                ROW_NUMBER() OVER(PARTITION BY property_bk ORDER BY property_bk) AS rn
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Lead"" l ON l.""LeadBK"" = psd.lead_bk
			                LEFT JOIN main.""GeneralLandUseCode"" gluc ON psd.general_land_use_code = gluc.""Name""
			                LEFT JOIN main.""InternalLandUseCode"" iluc ON psd.internal_land_use_code = iluc.""Name""
		                WHERE property_bk IS NOT NULL
	                )
	                UPDATE main.""Property"" p SET 
			                ""LeadId"" = COALESCE(pr.lead_id, ""LeadId"")
			                ,""Address"" = COALESCE(pr.property_address, ""Address"")
			                ,""City"" = COALESCE(pr.property_city, ""City"")
			                ,""ZipCode"" = COALESCE(pr.property_zip_code, ""ZipCode"")
			                ,""LegalDescription"" = COALESCE(pr.legal_description, ""LegalDescription"")
			                ,""LandStateCode"" = COALESCE(pr.land_state_code, ""LandStateCode"")
			                ,""ImprovementStateCode"" = COALESCE(pr.improvement_state_code, ""ImprovementStateCode"")
			                ,""LandUseCode"" = COALESCE(pr.land_use_code, ""LandUseCode"")
			                ,""InternalLandUseCodeId"" = COALESCE(pr.internal_land_use_code_id, ""InternalLandUseCodeId"")
			                ,""GeneralLandUseCodeId"" = COALESCE(pr.general_land_use_code_id, ""GeneralLandUseCodeId"")
			                ,""Over65SurvivingSpouse"" = COALESCE(pr.over_65_surviving_spouse, ""Over65SurvivingSpouse"")
			                ,""DisabilityExemption"" = COALESCE(pr.disability_exemption, ""DisabilityExemption"")
			                ,""Mortgage"" = COALESCE(pr.mortgage, ""Mortgage"")
			                ,""PaymentPlan"" = COALESCE(pr.payment_plan, ""PaymentPlan"")
			                ,""Veteran"" = COALESCE(pr.veteran, ""Veteran"")
			                ,""Bankruptcy"" = COALESCE(pr.bankruptcy, ""Bankruptcy"")
			                ,""ThirdPartyForeclosure"" = COALESCE(pr.third_party_foreclosure, ""ThirdPartyForeclosure"")
			                ,""LandAcres"" = COALESCE(pr.land_acres, ""LandAcres"")
			                ,""BuildingSqFt"" = COALESCE(pr.building_sq_ft, ""BuildingSqFt"")
			                ,""YearBuilt"" = COALESCE(pr.year_built, ""YearBuilt"")
			                ,""Latitude"" = COALESCE(pr.latitude, ""Latitude"")
			                ,""Longitude"" = COALESCE(pr.longitude, ""Longitude"")
			                ,""Homestead"" = COALESCE(pr.homestead, ""Homestead"")	
			                ,""RUAmount"" = COALESCE(pr.ru_amount, ""RUAmount"")	
			                ,""RULTVPercent"" = COALESCE(pr.ru_ltv_percent, ""RULTVPercent"")	
			                ,""LTVPercent"" = COALESCE(pr.ltv_percent, ""LTVPercent"")	
			                ,""ModifiedOn"" = LOCALTIMESTAMP
			                ,""ModifiedById"" = p_system_user_id
	                FROM pr
	                WHERE pr.rn = 1
		                AND p.""PropertyBK"" = pr.property_bk
		                AND (	""LeadId"" IS DISTINCT FROM COALESCE(pr.lead_id, ""LeadId"") OR
				                ""Address"" IS DISTINCT FROM COALESCE(pr.property_address, ""Address"") OR
				                ""City"" IS DISTINCT FROM COALESCE(pr.property_city, ""City"") OR
				                ""ZipCode"" IS DISTINCT FROM COALESCE(pr.property_zip_code, ""ZipCode"") OR
				                ""LegalDescription"" IS DISTINCT FROM COALESCE(pr.legal_description, ""LegalDescription"") OR
				                ""LandStateCode"" IS DISTINCT FROM COALESCE(pr.land_state_code, ""LandStateCode"") OR
				                ""ImprovementStateCode"" IS DISTINCT FROM COALESCE(pr.improvement_state_code, ""ImprovementStateCode"") OR
				                ""LandUseCode"" IS DISTINCT FROM COALESCE(pr.land_use_code, ""LandUseCode"") OR
			 	                ""InternalLandUseCodeId"" IS DISTINCT FROM COALESCE(pr.internal_land_use_code_id, ""InternalLandUseCodeId"") OR
				                ""GeneralLandUseCodeId"" IS DISTINCT FROM COALESCE(pr.general_land_use_code_id, ""GeneralLandUseCodeId"") OR
				                ""Over65SurvivingSpouse"" IS DISTINCT FROM COALESCE(pr.over_65_surviving_spouse, ""Over65SurvivingSpouse"") OR
				                ""DisabilityExemption"" IS DISTINCT FROM COALESCE(pr.disability_exemption, ""DisabilityExemption"") OR
				                ""Mortgage"" IS DISTINCT FROM COALESCE(pr.mortgage, ""Mortgage"") OR
				                ""PaymentPlan"" IS DISTINCT FROM COALESCE(pr.payment_plan, ""PaymentPlan"") OR
				                ""Veteran"" IS DISTINCT FROM COALESCE(pr.veteran, ""Veteran"") OR
				                ""Bankruptcy"" IS DISTINCT FROM COALESCE(pr.bankruptcy, ""Bankruptcy"") OR
				                ""ThirdPartyForeclosure"" IS DISTINCT FROM COALESCE(pr.third_party_foreclosure, ""ThirdPartyForeclosure"") OR
				                ""LandAcres"" IS DISTINCT FROM COALESCE(pr.land_acres, ""LandAcres"") OR
				                ""BuildingSqFt"" IS DISTINCT FROM COALESCE(pr.building_sq_ft, ""BuildingSqFt"") OR
				                ""YearBuilt"" IS DISTINCT FROM COALESCE(pr.year_built, ""YearBuilt"") OR
				                ""Latitude"" IS DISTINCT FROM COALESCE(pr.latitude, ""Latitude"") OR
				                ""Longitude"" IS DISTINCT FROM COALESCE(pr.longitude, ""Longitude"") OR
				                ""Homestead"" IS DISTINCT FROM COALESCE(pr.homestead, ""Homestead"") OR
				                ""RUAmount"" IS DISTINCT FROM COALESCE(pr.ru_amount, ""RUAmount"") OR
				                ""RULTVPercent"" IS DISTINCT FROM COALESCE(pr.ru_ltv_percent, ""RULTVPercent"") OR
				                ""LTVPercent"" IS DISTINCT FROM COALESCE(pr.ltv_percent, ""LTVPercent""));
													  
	                GET DIAGNOSTICS p_ucnt = ROW_COUNT;

	                /* Insert new Property */
	                WITH pr AS
	                (
		                SELECT property_bk, l.""Id"" as lead_id, county_id, parcel_id, cad_id, tax_id, folio_id, 
			                property_address, property_city, property_state_id, property_zip_code, legal_description, 
			                land_state_code, improvement_state_code, land_use_code, iluc.""Id"" as internal_land_use_code_id, 
			                COALESCE(gluc.""Id"", p_unknown_general_land_use_code_id) as general_land_use_code_id, 
			                CASE WHEN over_65_surviving_spouse IS NULL THEN false ELSE over_65_surviving_spouse END as over_65_surviving_spouse,
			                CASE WHEN disability_exemption IS NULL THEN false ELSE disability_exemption END as disability_exemption,
			                CASE WHEN mortgage IS NULL THEN false ELSE mortgage END as mortgage,
			                CASE WHEN payment_plan IS NULL THEN false ELSE payment_plan END as payment_plan,
			                CASE WHEN veteran IS NULL THEN false ELSE veteran END as veteran,
			                CASE WHEN bankruptcy IS NULL THEN false ELSE bankruptcy END as bankruptcy,
			                CASE WHEN third_party_foreclosure IS NULL THEN false ELSE third_party_foreclosure END as third_party_foreclosure,
			                land_acres, building_sq_ft, year_built, latitude, longitude,
			                homestead, ru_amount, ru_ltv_percent, ltv_percent,
			                SUM(amount_due) OVER(PARTITION BY property_bk ORDER BY property_bk) AS total_amount	,
			                SUM(amount_due) OVER(PARTITION BY property_bk, delinquency_tax_year ORDER BY property_bk, delinquency_tax_year) AS last_year_due,
			                ROW_NUMBER() OVER(PARTITION BY property_bk ORDER BY property_bk, delinquency_tax_year DESC) AS rn	
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Lead"" l ON l.""LeadBK"" = psd.lead_bk
			                LEFT JOIN main.""GeneralLandUseCode"" gluc ON psd.general_land_use_code = gluc.""Name""
			                LEFT JOIN main.""InternalLandUseCode"" iluc ON psd.internal_land_use_code = iluc.""Name""
			                LEFT JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
		                WHERE property_bk IS NOT NULL
			                AND p.""Id"" IS NULL
	                )
	                INSERT INTO main.""Property""(""Id"", ""LeadId"", ""PropertyBK"", ""ParcelId"", ""CADId"", ""TAXId"", ""FolioId"", ""StateId"", ""Address"", 
								                ""City"", ""ZipCode"", ""CountyId"", ""LegalDescription"", ""LandStateCode"", ""ImprovementStateCode"", 
								                ""LandUseCode"", ""InternalLandUseCodeId"",""GeneralLandUseCodeId"", ""Over65SurvivingSpouse"", ""DisabilityExemption"", 
								                ""Mortgage"", ""PaymentPlan"", ""Veteran"", ""Bankruptcy"", ""ThirdPartyForeclosure"", ""LandAcres"", ""BuildingSqFt"", 
								                ""YearBuilt"", ""Latitude"", ""Longitude"", ""Homestead"", ""RUAmount"", ""RULTVPercent"", ""LTVPercent"", 
								                ""LastYearDue"", ""TotalAmountDue"", ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")							 
	                SELECT uuid_generate_v4() as id, pr.lead_id, pr.property_bk, pr.parcel_id, pr.cad_id, pr.tax_id, pr.folio_id,
			                pr.property_state_id, pr.property_address, pr.property_city, pr.property_zip_code, pr.county_id,
			                pr.legal_description, pr.land_state_code, pr.improvement_state_code, pr.land_use_code, pr.internal_land_use_code_id,
			                pr.general_land_use_code_id, pr.over_65_surviving_spouse, pr.disability_exemption, pr.mortgage, pr.payment_plan, pr.veteran, 
			                pr.bankruptcy, pr.third_party_foreclosure, pr.land_acres, pr.building_sq_ft, pr.year_built, pr.latitude, pr.longitude,
			                pr.homestead, pr.ru_amount, pr.ru_ltv_percent, pr.ltv_percent, 
			                pr.last_year_due, pr.total_amount, LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
	                FROM pr
	                WHERE pr.rn = 1;
													  
	                GET DIAGNOSTICS p_icnt = ROW_COUNT;
	
	                RETURN QUERY
	                SELECT COALESCE(p_ucnt, 0), COALESCE(p_icnt, 0);						  
							 
                END;
                $function$;



                /* DROP load_main_property_valuation FUNCTION */
                DROP FUNCTION IF EXISTS stage.load_main_property_valuation();
                /* CREATE load_main_property_valuation FUNCTION */
                CREATE OR REPLACE FUNCTION stage.load_main_property_valuation()
                 RETURNS TABLE(updated_count numeric, inserted_count numeric)
                 LANGUAGE plpgsql
                AS $function$
	                DECLARE 
		                p_system_user_id UUID;
		                p_ucnt numeric;
		                p_icnt numeric;
                BEGIN

	                p_system_user_id = '00000000-0000-0000-0000-000000000001';

	                DROP TABLE IF EXISTS tmp_property;
	                CREATE TEMP TABLE tmp_property( property_id uuid); 

	                /* Update existing PropertyValuation */
	                WITH prv AS
	                (
		                SELECT DISTINCT p.""Id"" as property_id, appraised_year, land_value, improvement_value, appraised_value,
			                ROW_NUMBER() OVER(PARTITION BY property_bk ORDER BY property_bk) AS rn
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
		                WHERE property_bk IS NOT NULL
			                AND appraised_year IS NOT NULL
			                AND (   land_value IS NOT NULL
				                 OR improvement_value IS NOT NULL
				                 OR appraised_value IS NOT NULL)
	                ),
	                upd AS(
			                UPDATE main.""PropertyValuation"" pv SET 
					                 ""LandValue"" = COALESCE(prv.land_value, pv.""LandValue"")
					                ,""ImprovementValue"" = COALESCE(prv.improvement_value, pv.""ImprovementValue"")
					                ,""AppraisedValue"" = COALESCE(prv.appraised_value, pv.""AppraisedValue"")
					                ,""ModifiedOn"" = LOCALTIMESTAMP
					                ,""ModifiedById"" = p_system_user_id
			                FROM prv
			                WHERE prv.rn = 1
				                AND pv.""PropertyId"" = prv.property_id
				                AND pv.""AppraisedYear"" = prv.appraised_year
				                AND (	pv.""LandValue"" IS DISTINCT FROM COALESCE(prv.land_value, pv.""LandValue"") OR
						                pv.""ImprovementValue"" IS DISTINCT FROM COALESCE(prv.improvement_value, pv.""ImprovementValue"") OR
						                pv.""AppraisedValue"" IS DISTINCT FROM COALESCE(prv.appraised_value, pv.""AppraisedValue""))
			                RETURNING ""PropertyId""
		                )
	                INSERT INTO tmp_property 
	                SELECT ""PropertyId"" FROM upd;  
	                GET DIAGNOSTICS p_ucnt = ROW_COUNT;
															  
	                /* Insert new PropertyValuation */
	                WITH prv AS
	                (
		                SELECT DISTINCT p.""Id"" as property_id, appraised_year, land_value, improvement_value, appraised_value,
			                ROW_NUMBER() OVER(PARTITION BY property_bk ORDER BY property_bk) AS rn
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
		                WHERE property_bk IS NOT NULL
			                AND appraised_year IS NOT NULL
			                AND (   land_value IS NOT NULL
				                 OR improvement_value IS NOT NULL
				                 OR appraised_value IS NOT NULL)
	                ),
	                ins AS(
			                INSERT INTO main.""PropertyValuation""(""Id"", ""PropertyId"", ""AppraisedYear"", ""LandValue"", ""ImprovementValue"", ""AppraisedValue"",
												                ""IsActive"", ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")		
			                SELECT uuid_generate_v4() as id, prv.property_id, prv.appraised_year, prv.land_value, prv.improvement_value,
					                prv.appraised_value, FALSE, LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
			                FROM prv
			                WHERE prv.rn = 1
				                AND NOT EXISTS ( SELECT 1 FROM main.""PropertyValuation"" pv WHERE pv.""PropertyId"" = prv.property_id AND pv.""AppraisedYear"" = prv.appraised_year)
			                RETURNING ""PropertyId""
		                )
	                INSERT INTO tmp_property 
	                SELECT ""PropertyId"" FROM ins;  

	                GET DIAGNOSTICS p_icnt = ROW_COUNT;


	                /* Disable old propery valuations */
	                WITH a AS 
	                (
		                SELECT pv.""Id"",
			                 CASE ROW_NUMBER() OVER(PARTITION BY ""PropertyId"" ORDER BY ""PropertyId"", ""AppraisedYear"" DESC) WHEN 1 THEN TRUE ELSE FALSE END AS ""IsActive""
		                FROM main.""PropertyValuation"" pv
			                INNER JOIN tmp_property ON pv.""PropertyId"" = tmp_property.property_id
	                )
	                UPDATE main.""PropertyValuation"" pv
	                SET ""IsActive"" = false
		                ,""ModifiedOn"" = LOCALTIMESTAMP
		                ,""ModifiedById"" = p_system_user_id 
	                FROM a 
	                WHERE pv.""Id"" = a.""Id""
		                AND pv.""IsActive"" = true 
		                AND a.""IsActive"" = false;

	                /* Enable new propery valuations */
	                WITH a AS 
	                (
		                SELECT pv.""Id"",
			                 CASE ROW_NUMBER() OVER(PARTITION BY ""PropertyId"" ORDER BY ""PropertyId"", ""AppraisedYear"" DESC) WHEN 1 THEN TRUE ELSE FALSE END AS ""IsActive""
		                FROM main.""PropertyValuation"" pv
			                INNER JOIN tmp_property ON pv.""PropertyId"" = tmp_property.property_id
	                )
	                UPDATE main.""PropertyValuation"" pv
	                SET ""IsActive"" = true
		                ,""ModifiedOn"" = LOCALTIMESTAMP
		                ,""ModifiedById"" = p_system_user_id 
	                FROM a 
	                WHERE pv.""Id"" = a.""Id""
		                AND pv.""IsActive"" = false 
		                AND a.""IsActive"" = true;
	
	                DROP TABLE IF EXISTS tmp_property;

	                RETURN QUERY
	                SELECT COALESCE(p_ucnt, 0), COALESCE(p_icnt, 0);
							 
                END;
                $function$;


                /* DROP load_main_property_supplemental_event_data FUNCTION */
                DROP FUNCTION IF EXISTS stage.load_main_property_supplemental_event_data();
                /* CREATE load_main_property_supplemental_event_data FUNCTION */
                CREATE OR REPLACE FUNCTION stage.load_main_property_supplemental_event_data()
                 RETURNS TABLE(updated_count numeric, inserted_count numeric)
                 LANGUAGE plpgsql
                AS $function$
	                DECLARE 
		                p_system_user_id UUID;
		                p_ucnt numeric;
		                p_icnt numeric;
                BEGIN

	                p_system_user_id = '00000000-0000-0000-0000-000000000001';

	                /* Update existing PropertySupplementalEventData */
	                WITH sd AS
	                (
		                SELECT d.""Id"" as delinquency_id, last_sale_date, last_sale_amount, mortgage_lender_1, 
			                mortgage_loan_amount_1, mortgage_origination_date_1, mortgage_maturity_date_1, mortgage_lender_2,
			                mortgage_loan_amount_2, mortgage_origination_date_2, mortgage_maturity_date_2, inspector_comment, 
			                inspector_property_rating, inspector_area_rating, inspector_occupied, inspector_roof_condition, 
			                inspector_lawn_maintained, open_liens, closed_liens, recent_buyer_name, recent_buyer_rate, 
			                advertisement_batch, advertisement_number, assessor_url, treasurer_url,
			                ROW_NUMBER() OVER(PARTITION BY event_batch_id, property_bk ORDER BY event_batch_id, property_bk) AS rn
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Event"" e ON e.""EventNumber"" = psd.event_batch_id
			                INNER JOIN main.""Delinquency"" d ON d.""PropertyId"" = p.""Id"" AND d.""EventId"" = e.""Id""
		                WHERE property_bk IS NOT NULL
		                AND event_batch_id IS NOT NULL
		                AND (last_sale_date IS NOT NULL  
			                 OR last_sale_amount IS NOT NULL
			                 OR mortgage_lender_1 IS NOT NULL
			                 OR mortgage_loan_amount_1 IS NOT NULL
			                 OR mortgage_origination_date_1  IS NOT NULL
			                 OR mortgage_maturity_date_1  IS NOT NULL
			                 OR mortgage_lender_2  IS NOT NULL
			                 OR mortgage_loan_amount_2  IS NOT NULL
			                 OR mortgage_origination_date_2  IS NOT NULL
			                 OR mortgage_maturity_date_2  IS NOT NULL
			                 OR inspector_comment  IS NOT NULL
			                 OR inspector_property_rating  IS NOT NULL
			                 OR inspector_area_rating  IS NOT NULL
			                 OR inspector_occupied  IS NOT NULL
			                 OR inspector_roof_condition  IS NOT NULL
			                 OR inspector_lawn_maintained  IS NOT NULL
			                 OR open_liens  IS NOT NULL
			                 OR closed_liens  IS NOT NULL
			                 OR recent_buyer_name  IS NOT NULL
			                 OR recent_buyer_rate  IS NOT NULL
			                 OR advertisement_batch  IS NOT NULL
			                 OR advertisement_number  IS NOT NULL
			                 OR assessor_url  IS NOT NULL
			                 OR treasurer_url  IS NOT NULL
		                )
	                )
	                UPDATE main.""PropertySupplementalEventData"" psed SET 
			                 ""LastSaleDate"" = COALESCE(sd.last_sale_date, psed.""LastSaleDate"")
			                ,""LastSaleAmount"" = COALESCE(sd.last_sale_amount, psed.""LastSaleAmount"")
			                ,""MortgageLender1"" = COALESCE(sd.mortgage_lender_1, psed.""MortgageLender1"")
			                ,""MortgageLoanAmount1"" = COALESCE(sd.mortgage_loan_amount_1, psed.""MortgageLoanAmount1"")
			                ,""MortgageOriginationDate1"" = COALESCE(sd.mortgage_origination_date_1, psed.""MortgageOriginationDate1"")
			                ,""MortgageMaturityDate1"" = COALESCE(sd.mortgage_maturity_date_1, psed.""MortgageMaturityDate1"")
			                ,""MortgageLender2"" = COALESCE(sd.mortgage_lender_2, psed.""MortgageLender2"")
			                ,""MortgageLoanAmount2"" = COALESCE(sd.mortgage_loan_amount_2, psed.""MortgageLoanAmount2"")
			                ,""MortgageOriginationDate2"" = COALESCE(sd.mortgage_origination_date_2, psed.""MortgageOriginationDate2"")
			                ,""MortgageMaturityDate2"" = COALESCE(sd.mortgage_maturity_date_2, psed.""MortgageMaturityDate2"")
			                ,""InspectorComment"" = COALESCE(sd.inspector_comment, psed.""InspectorComment"")
			                ,""InspectorPropertyRating"" = COALESCE(sd.inspector_property_rating, psed.""InspectorPropertyRating"")
			                ,""InspectorAreaRating"" = COALESCE(sd.inspector_area_rating, psed.""InspectorAreaRating"")
			                ,""InspectorOccupied"" = COALESCE(sd.inspector_occupied, psed.""InspectorOccupied"")
			                ,""InspectorRoofCondition"" = COALESCE(sd.inspector_roof_condition, psed.""InspectorRoofCondition"")
			                ,""InspectorLawnMaintained"" = COALESCE(sd.inspector_lawn_maintained, psed.""InspectorLawnMaintained"")
			                ,""OpenLiens"" = COALESCE(sd.open_liens, psed.""OpenLiens"")
			                ,""ClosedLiens"" = COALESCE(sd.closed_liens, psed.""ClosedLiens"")
			                ,""RecentBuyerName"" = COALESCE(sd.recent_buyer_name, psed.""RecentBuyerName"")
			                ,""RecentBuyerRate"" = COALESCE(sd.recent_buyer_rate, psed.""RecentBuyerRate"")
			                ,""AdvertisementBatch"" = COALESCE(sd.advertisement_batch, psed.""AdvertisementBatch"")
			                ,""AdvertisementNumber"" = COALESCE(sd.advertisement_number, psed.""AdvertisementNumber"")
			                ,""AssessorURL"" = COALESCE(sd.assessor_url, psed.""AssessorURL"")
			                ,""TreasurerURL"" = COALESCE(sd.treasurer_url, psed.""TreasurerURL"")
			                ,""ModifiedOn"" = LOCALTIMESTAMP
			                ,""ModifiedById"" = p_system_user_id
	                FROM sd
	                WHERE sd.rn = 1
		                AND psed.""DelinquencyId"" = sd.delinquency_id
		                AND (	   psed.""LastSaleDate"" IS DISTINCT FROM COALESCE(sd.last_sale_date, psed.""LastSaleDate"")
				                OR psed.""LastSaleAmount"" IS DISTINCT FROM COALESCE(sd.last_sale_amount, psed.""LastSaleAmount"")
				                OR psed.""MortgageLender1"" IS DISTINCT FROM COALESCE(sd.mortgage_lender_1, psed.""MortgageLender1"")
				                OR psed.""MortgageLoanAmount1"" IS DISTINCT FROM COALESCE(sd.mortgage_loan_amount_1, psed.""MortgageLoanAmount1"")
				                OR psed.""MortgageOriginationDate1"" IS DISTINCT FROM COALESCE(sd.mortgage_origination_date_1, psed.""MortgageOriginationDate1"")
				                OR psed.""MortgageMaturityDate1"" IS DISTINCT FROM COALESCE(sd.mortgage_maturity_date_1, psed.""MortgageMaturityDate1"")
				                OR psed.""MortgageLender2"" IS DISTINCT FROM COALESCE(sd.mortgage_lender_2, psed.""MortgageLender2"")
				                OR psed.""MortgageLoanAmount2"" IS DISTINCT FROM COALESCE(sd.mortgage_loan_amount_2, psed.""MortgageLoanAmount2"")
				                OR psed.""MortgageOriginationDate2"" IS DISTINCT FROM COALESCE(sd.mortgage_origination_date_2, psed.""MortgageOriginationDate2"")
				                OR psed.""MortgageMaturityDate2"" IS DISTINCT FROM COALESCE(sd.mortgage_maturity_date_2, psed.""MortgageMaturityDate2"")
				                OR psed.""InspectorComment"" IS DISTINCT FROM COALESCE(sd.inspector_comment, psed.""InspectorComment"")
				                OR psed.""InspectorPropertyRating"" IS DISTINCT FROM COALESCE(sd.inspector_property_rating, psed.""InspectorPropertyRating"")
				                OR psed.""InspectorAreaRating"" IS DISTINCT FROM COALESCE(sd.inspector_area_rating, psed.""InspectorAreaRating"")
				                OR psed.""InspectorOccupied"" IS DISTINCT FROM COALESCE(sd.inspector_occupied, psed.""InspectorOccupied"")
			 	                OR psed.""InspectorRoofCondition"" IS DISTINCT FROM COALESCE(sd.inspector_roof_condition, psed.""InspectorRoofCondition"")
			 	                OR psed.""InspectorLawnMaintained"" IS DISTINCT FROM COALESCE(sd.inspector_lawn_maintained, psed.""InspectorLawnMaintained"")
				                OR psed.""OpenLiens"" IS DISTINCT FROM COALESCE(sd.open_liens, psed.""OpenLiens"")
				                OR psed.""ClosedLiens"" IS DISTINCT FROM COALESCE(sd.closed_liens, psed.""ClosedLiens"")
				                OR psed.""RecentBuyerName"" IS DISTINCT FROM COALESCE(sd.recent_buyer_name, psed.""RecentBuyerName"")
				                OR psed.""RecentBuyerRate"" IS DISTINCT FROM COALESCE(sd.recent_buyer_rate, psed.""RecentBuyerRate"")
				                OR psed.""AdvertisementBatch"" IS DISTINCT FROM COALESCE(sd.advertisement_batch, psed.""AdvertisementBatch"")
				                OR psed.""AdvertisementNumber"" IS DISTINCT FROM COALESCE(sd.advertisement_number, psed.""AdvertisementNumber"")
				                OR psed.""AssessorURL"" IS DISTINCT FROM COALESCE(sd.assessor_url, psed.""AssessorURL"")
				                OR psed.""TreasurerURL"" IS DISTINCT FROM COALESCE(sd.treasurer_url, psed.""TreasurerURL""));
	
	                GET DIAGNOSTICS p_ucnt = ROW_COUNT;

	                /* Insert new PropertySupplementalEventData */
	                WITH sd AS
	                (
		                SELECT d.""Id"" as delinquency_id, p.""Id"" as property_id, last_sale_date, last_sale_amount, mortgage_lender_1, 
			                mortgage_loan_amount_1, mortgage_origination_date_1, mortgage_maturity_date_1, mortgage_lender_2,
			                mortgage_loan_amount_2, mortgage_origination_date_2, mortgage_maturity_date_2, inspector_comment, 
			                inspector_property_rating, inspector_area_rating, inspector_occupied, inspector_roof_condition, 
			                inspector_lawn_maintained, open_liens, closed_liens, recent_buyer_name, recent_buyer_rate, 
			                advertisement_batch, advertisement_number, assessor_url, treasurer_url,
			                ROW_NUMBER() OVER(PARTITION BY event_batch_id, property_bk ORDER BY event_batch_id, property_bk) AS rn
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Event"" e ON e.""EventNumber"" = psd.event_batch_id
			                INNER JOIN main.""Delinquency"" d ON d.""PropertyId"" = p.""Id"" AND d.""EventId"" = e.""Id""
		                WHERE property_bk IS NOT NULL
		                AND event_batch_id IS NOT NULL
		                AND (last_sale_date IS NOT NULL  
			                 OR last_sale_amount IS NOT NULL
			                 OR mortgage_lender_1 IS NOT NULL
			                 OR mortgage_loan_amount_1 IS NOT NULL
			                 OR mortgage_origination_date_1  IS NOT NULL
			                 OR mortgage_maturity_date_1  IS NOT NULL
			                 OR mortgage_lender_2  IS NOT NULL
			                 OR mortgage_loan_amount_2  IS NOT NULL
			                 OR mortgage_origination_date_2  IS NOT NULL
			                 OR mortgage_maturity_date_2  IS NOT NULL
			                 OR inspector_comment  IS NOT NULL
			                 OR inspector_property_rating  IS NOT NULL
			                 OR inspector_area_rating  IS NOT NULL
			                 OR inspector_occupied  IS NOT NULL
			                 OR inspector_roof_condition  IS NOT NULL
			                 OR inspector_lawn_maintained  IS NOT NULL
			                 OR open_liens  IS NOT NULL
			                 OR closed_liens  IS NOT NULL
			                 OR recent_buyer_name  IS NOT NULL
			                 OR recent_buyer_rate  IS NOT NULL
			                 OR advertisement_batch  IS NOT NULL
			                 OR advertisement_number  IS NOT NULL
			                 OR assessor_url  IS NOT NULL
			                 OR treasurer_url  IS NOT NULL
			                 )
	                )
	                INSERT INTO main.""PropertySupplementalEventData""(""Id"", ""DelinquencyId"", ""PropertyId"", ""LastSaleDate"", ""LastSaleAmount"", 
				                ""MortgageLender1"", ""MortgageLoanAmount1"", ""MortgageOriginationDate1"", ""MortgageMaturityDate1"", 
				                ""MortgageLender2"", ""MortgageLoanAmount2"", ""MortgageOriginationDate2"", ""MortgageMaturityDate2"", 
				                ""InspectorComment"", ""InspectorPropertyRating"", ""InspectorAreaRating"", ""InspectorOccupied"", 
				                ""InspectorRoofCondition"", ""InspectorLawnMaintained"", ""OpenLiens"", ""ClosedLiens"", ""RecentBuyerName"", 
				                ""RecentBuyerRate"", ""AdvertisementBatch"", ""AdvertisementNumber"", ""AssessorURL"", ""TreasurerURL"",
				                ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")		
	                SELECT uuid_generate_v4() as id, sd.delinquency_id, sd.property_id, sd.last_sale_date, sd.last_sale_amount, 
				                sd.mortgage_lender_1, sd.mortgage_loan_amount_1, sd.mortgage_origination_date_1, sd.mortgage_maturity_date_1, 
				                sd.mortgage_lender_2, sd.mortgage_loan_amount_2, sd.mortgage_origination_date_2, sd.mortgage_maturity_date_2, 
				                sd.inspector_comment, sd.inspector_property_rating, sd.inspector_area_rating, sd.inspector_occupied, 
				                sd.inspector_roof_condition, sd.inspector_lawn_maintained, sd.open_liens, sd.closed_liens, sd.recent_buyer_name, 
				                sd.recent_buyer_rate, sd.advertisement_batch, sd.advertisement_number, sd.assessor_url, sd.treasurer_url,
				                LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
	                FROM sd
	                WHERE sd.rn = 1
		                AND NOT EXISTS ( SELECT 1 FROM main.""PropertySupplementalEventData"" psed WHERE psed.""DelinquencyId"" = sd.delinquency_id);
	
	                GET DIAGNOSTICS p_icnt = ROW_COUNT;
	
	                RETURN QUERY
	                SELECT COALESCE(p_ucnt, 0), COALESCE(p_icnt, 0);
								 
                END;
                $function$;




                /* DROP load_main_delinquency FUNCTION */
                DROP FUNCTION IF EXISTS stage.load_main_delinquency();
                /* CREATE load_main_delinquency FUNCTION */
                CREATE OR REPLACE FUNCTION stage.load_main_delinquency()
                 RETURNS TABLE(updated_count numeric, inserted_count numeric)
                 LANGUAGE plpgsql
                AS $function$
	                DECLARE 
		                p_system_user_id UUID;
		                p_ucnt numeric;
		                p_icnt numeric;
		                p_tucnt numeric;
		                p_ticnt numeric;
                BEGIN

	                p_system_user_id = '00000000-0000-0000-0000-000000000001';
	                p_ucnt = 0;
	                p_icnt = 0;
	                p_tucnt = 0;
	                p_ticnt = 0;


	                /* Update Loan Delinquency */
	                WITH res AS
	                (
		                SELECT d.""Id"" as delinquency_id
			                ,psd.delinquency_tax_year
			                ,sum(psd.amount_due) as amount
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Delinquency"" d ON d.""PropertyId"" = p.""Id"" 
				                AND d.""DelinquencyTaxYear"" = psd.delinquency_tax_year
				                AND d.""EventId"" IS NULL 
		                WHERE psd.property_bk IS NOT NULL
			                AND psd.delinquency_tax_year IS NOT null
			                AND psd.event_batch_id IS NULL
		                GROUP BY d.""Id"", psd.delinquency_tax_year  
	                )
	                UPDATE main.""Delinquency"" d SET 
			                ""Amount"" = COALESCE(res.amount, d.""Amount""),
			                ""ModifiedOn"" = LOCALTIMESTAMP,
			                ""ModifiedById"" = p_system_user_id
	                FROM res
	                WHERE d.""Id"" = res.delinquency_id
		                AND d.""Amount"" IS DISTINCT FROM COALESCE(res.amount, d.""Amount"");


	                /* Update Lien Delinquency */
	                WITH res AS
	                (
		                SELECT d.""Id"" as delinquency_id
			                ,delinquency_tax_year
			                ,sum(amount_due) as amount
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Event"" e ON e.""EventNumber"" = psd.event_batch_id
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Delinquency"" d ON d.""PropertyId"" = p.""Id"" 
				                AND d.""DelinquencyTaxYear"" = psd.delinquency_tax_year
				                AND d.""EventId"" = e.""Id""
		                WHERE property_bk IS NOT NULL
			                AND delinquency_tax_year IS NOT NULL	
		                GROUP BY d.""Id"", delinquency_tax_year  
	                )
	                ,upd AS (
		                UPDATE main.""Delinquency"" d SET 
				                ""Amount"" = COALESCE(res.amount, d.""Amount""),
				                ""ModifiedOn"" = LOCALTIMESTAMP,
				                ""ModifiedById"" = p_system_user_id
		                FROM res
		                WHERE d.""Id"" = res.delinquency_id
			                AND d.""Amount"" IS DISTINCT FROM COALESCE(res.amount, d.""Amount"")
		                RETURNING ""Id"", ""EventId""
	                )
	                INSERT INTO main.""EtlDelinquency"" (""EventId"", ""DelinquencyId"", ""CreatedOn"")
	                SELECT ""EventId"", ""Id"", LOCALTIMESTAMP FROM upd;


	                /* Insert new Loan Delinquency */
	                WITH d AS
	                (
		                SELECT p.""Id"" as property_id
			                ,psd.delinquency_tax_year
			                ,sum(psd.amount_due) as amount
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
		                WHERE property_bk IS NOT NULL
			                AND psd.delinquency_tax_year IS NOT null
			                AND psd.event_batch_id IS NULL
		                GROUP BY p.""Id"", psd.delinquency_tax_year  
	                )
	                INSERT INTO main.""Delinquency""(""Id"", ""PropertyId"", ""DelinquencyTaxYear"", ""Amount"", ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")		
	                SELECT uuid_generate_v4() as id, d.property_id, d.delinquency_tax_year, d.amount, LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
	                FROM d
	                WHERE NOT EXISTS ( SELECT 1 FROM main.""Delinquency"" dl 
						                WHERE dl.""PropertyId"" = d.property_id 
							                AND dl.""DelinquencyTaxYear"" = d.delinquency_tax_year 
							                AND dl.""EventId"" IS NULL
						                );



	                /* Insert new Lien Delinquency */
	                WITH d AS
	                (
		                SELECT p.""Id"" as property_id
			                ,e.""Id"" as event_id
			                ,delinquency_tax_year
			                ,sum(amount_due) as amount
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Event"" e ON e.""EventNumber"" = psd.event_batch_id
		                WHERE property_bk IS NOT NULL
			                AND delinquency_tax_year IS NOT NULL
		                GROUP BY p.""Id"", e.""Id"", delinquency_tax_year  
	                )
	                ,ins AS (
		                INSERT INTO main.""Delinquency""(""Id"", ""PropertyId"", ""EventId"", ""DelinquencyTaxYear"", ""Amount"", ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")		
		                SELECT uuid_generate_v4() as id, d.property_id, d.event_id, d.delinquency_tax_year, d.amount, LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
		                FROM d
		                WHERE NOT EXISTS ( SELECT 1 FROM main.""Delinquency"" dl 
							                WHERE dl.""PropertyId"" = d.property_id 
								                AND dl.""DelinquencyTaxYear"" = d.delinquency_tax_year
								                AND dl.""EventId"" = d.event_id
						                 )
		                RETURNING ""Id"", ""EventId""
	                )
	                INSERT INTO main.""EtlDelinquency"" (""EventId"", ""DelinquencyId"", ""CreatedOn"")
	                SELECT ""EventId"", ""Id"", LOCALTIMESTAMP FROM ins;



	                /* Update Loan CollectingEntity */
	                WITH res AS
	                (
		                SELECT DISTINCT dl.""Id"" as delinquency_id, cet.""Id"" as type_id, psd.amount_due, p.""Id"" as property_id
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Delinquency"" dl ON dl.""PropertyId"" = p.""Id"" 
				                AND dl.""DelinquencyTaxYear"" = psd.delinquency_tax_year::smallint
			                INNER JOIN main.""CollectingEntityType"" cet ON LOWER(cet.""Name"") = LOWER(psd.collecting_entity)
		                WHERE psd.event_batch_id IS NULL 
			                AND psd.property_bk IS NOT NULL
			                AND psd.amount_due IS NOT NULL
	                )
	                UPDATE main.""CollectingEntity"" ce SET 
			                ""AmountDue"" = COALESCE(res.amount_due, ce.""AmountDue""),
			                ""ModifiedOn"" = LOCALTIMESTAMP,
			                ""ModifiedById"" = p_system_user_id
	                FROM res
	                WHERE ce.""DelinquencyId"" = res.delinquency_id
		                AND ce.""CollectingEntityTypeId"" = res.type_id
		                AND ce.""AmountDue"" IS DISTINCT FROM COALESCE(res.amount_due, ce.""AmountDue"");
                              
	                GET DIAGNOSTICS p_ucnt = ROW_COUNT;
	                p_tucnt = p_tucnt + p_ucnt;


	                /* Update Lien CollectingEntity */
	                WITH res AS
	                (
		                SELECT DISTINCT dl.""Id"" as delinquency_id, cet.""Id"" as type_id, psd.amount_due, p.""Id"" as property_id
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Event"" e ON e.""EventNumber"" = psd.event_batch_id
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Delinquency"" dl ON dl.""PropertyId"" = p.""Id"" 
				                AND dl.""DelinquencyTaxYear"" = psd.delinquency_tax_year::smallint
				                AND dl.""EventId"" = e.""Id"" 
			                INNER JOIN main.""CollectingEntityType"" cet ON LOWER(cet.""Name"") = LOWER(psd.collecting_entity)
		                WHERE property_bk IS NOT NULL
			                AND psd.amount_due IS NOT NULL
	                )
	                UPDATE main.""CollectingEntity"" ce SET 
			                ""AmountDue"" = COALESCE(res.amount_due, ce.""AmountDue""),
			                ""ModifiedOn"" = LOCALTIMESTAMP,
			                ""ModifiedById"" = p_system_user_id
	                FROM res
	                WHERE ce.""DelinquencyId"" = res.delinquency_id
		                AND ce.""CollectingEntityTypeId"" = res.type_id
		                AND ce.""AmountDue"" IS DISTINCT FROM COALESCE(res.amount_due, ce.""AmountDue"");
                              
	                GET DIAGNOSTICS p_ucnt = ROW_COUNT;
	                p_tucnt = p_tucnt + p_ucnt;


	                /* Insert new Loan CollectingEntity */
	                WITH res AS
	                (
		                SELECT DISTINCT dl.""Id"" as delinquency_id, cet.""Id"" as type_id, psd.amount_due
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Delinquency"" dl ON dl.""PropertyId"" = p.""Id"" 
				                AND dl.""DelinquencyTaxYear"" = psd.delinquency_tax_year
			                INNER JOIN main.""CollectingEntityType"" cet ON LOWER(cet.""Name"") = LOWER(psd.collecting_entity)
		                WHERE psd.event_batch_id IS NULL 
			                AND psd.property_bk IS NOT NULL
			                AND psd.amount_due IS NOT NULL
	                )
	                INSERT INTO main.""CollectingEntity""(""Id"", ""DelinquencyId"", ""CollectingEntityTypeId"", ""AmountDue"", 
										                ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")		
	                SELECT uuid_generate_v4() as id, res.delinquency_id, res.type_id, res.amount_due,
			                LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
	                FROM res
	                WHERE NOT EXISTS ( SELECT 1 FROM main.""CollectingEntity"" ce 
					                   WHERE ce.""DelinquencyId"" = res.delinquency_id 
					  	                AND ce.""CollectingEntityTypeId"" = res.type_id);
	
	                GET DIAGNOSTICS p_icnt = ROW_COUNT;
	                p_ticnt = p_ticnt + p_icnt;


	                /* Insert new Lien CollectingEntity */
	                WITH res AS
	                (
		                SELECT DISTINCT dl.""Id"" as delinquency_id, cet.""Id"" as type_id, psd.amount_due
		                FROM stage.synergy_source_data psd
			                INNER JOIN main.""Event"" e ON e.""EventNumber"" = psd.event_batch_id
			                INNER JOIN main.""Property"" p ON p.""PropertyBK"" = psd.property_bk
			                INNER JOIN main.""Delinquency"" dl ON dl.""PropertyId"" = p.""Id"" 
				                AND dl.""DelinquencyTaxYear"" = psd.delinquency_tax_year
				                AND dl.""EventId"" = e.""Id"" 
			                INNER JOIN main.""CollectingEntityType"" cet ON LOWER(cet.""Name"") = LOWER(psd.collecting_entity)
		                WHERE property_bk IS NOT NULL
			                AND psd.amount_due IS NOT NULL
	                )
	                INSERT INTO main.""CollectingEntity""(""Id"", ""DelinquencyId"", ""CollectingEntityTypeId"", ""AmountDue"", 
										                ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"")		
	                SELECT uuid_generate_v4() as id, res.delinquency_id, res.type_id, res.amount_due,
			                LOCALTIMESTAMP, p_system_user_id, LOCALTIMESTAMP, p_system_user_id
	                FROM res
	                WHERE NOT EXISTS ( SELECT 1 FROM main.""CollectingEntity"" ce 
					                   WHERE ce.""DelinquencyId"" = res.delinquency_id 
					  	                AND ce.""CollectingEntityTypeId"" = res.type_id);
	
	                GET DIAGNOSTICS p_icnt =  ROW_COUNT;
	                p_ticnt = p_ticnt + p_icnt;

	 
	                RETURN QUERY
	                SELECT COALESCE(p_ucnt, 0), COALESCE(p_icnt, 0);		
	
                END;
                $function$;



                /* DROP refresh_total_amounts FUNCTION */
                DROP FUNCTION IF EXISTS stage.refresh_total_amounts();
                /* CREATE refresh_total_amounts FUNCTION */
                CREATE OR REPLACE FUNCTION stage.refresh_total_amounts()
                 RETURNS TABLE(updated_count numeric, inserted_count numeric)
                 LANGUAGE plpgsql
                AS $function$
	                DECLARE 
		                p_system_user_id UUID;
		                p_ucnt numeric;
		                p_utotal numeric;
                BEGIN

	                p_system_user_id = '00000000-0000-0000-0000-000000000001';
	                p_utotal = 0;
	
	
		                /* Update properties total amount and last year due */
		                WITH pr AS(
				                SELECT d.""PropertyId"",
					                SUM(d.""Amount"") OVER(PARTITION BY d.""PropertyId"" ORDER BY d.""PropertyId"") AS ""TotalAmount"",
					                SUM(d.""Amount"") OVER(PARTITION BY d.""PropertyId"", d.""DelinquencyTaxYear"" ORDER BY d.""PropertyId"", d.""DelinquencyTaxYear"") AS ""LastYearDue"",
					                ROW_NUMBER() OVER(PARTITION BY d.""PropertyId"" ORDER BY d.""PropertyId"", d.""DelinquencyTaxYear"" DESC) AS rn	
				                FROM main.""Delinquency"" d
				                WHERE EXISTS (SELECT 1 FROM main.""Property"" p
								                INNER JOIN stage.synergy_source_data sd on p.""PropertyBK"" = sd.property_bk
								                WHERE  p.""Id"" = d.""PropertyId"")
			                )
		                 UPDATE main.""Property"" p
		                 SET ""LastYearDue"" = COALESCE(pr.""LastYearDue"", p.""LastYearDue"")
		 	                ,""TotalAmountDue"" = COALESCE(pr.""TotalAmount"", p.""TotalAmountDue"")
			                ,""ModifiedOn"" = LOCALTIMESTAMP
			                ,""ModifiedById"" = p_system_user_id 
		                 FROM pr
		                 WHERE pr.rn = 1
		 	                AND p.""Id"" = pr.""PropertyId""
		 	                AND p.""TotalAmountDue"" IS DISTINCT FROM COALESCE(pr.""TotalAmount"", p.""TotalAmountDue"");
		 
		                GET DIAGNOSTICS p_ucnt = ROW_COUNT;
		                p_utotal = p_utotal + COALESCE(p_ucnt, 0);
		 
		 		
		                /* Update leads TotalAmountDueProperties and AppraisedValueOfProperties */
		                WITH lead AS(
				                SELECT p.""LeadId""
					                ,SUM(p.""TotalAmountDue"") AS ""TotalAmountDueProperties""
					                ,SUM(pv.""AppraisedValue"") AS ""AppraisedValueOfProperties""
				                FROM main.""Property"" p
					                LEFT JOIN main.""PropertyValuation"" pv ON pv.""PropertyId"" = p.""Id"" AND pv.""IsActive"" = true
				                WHERE EXISTS (SELECT 1 FROM main.""Lead"" l
								                INNER JOIN stage.synergy_source_data sd ON l.""LeadBK"" = sd.lead_bk
								                WHERE  l.""Id"" = p.""LeadId"")
				                GROUP BY p.""LeadId""
				                )
		                 UPDATE main.""Lead"" l
		                 SET ""TotalAmountDueProperties"" = COALESCE(lead.""TotalAmountDueProperties"", l.""TotalAmountDueProperties"")
		 	                ,""AppraisedValueOfProperties"" = COALESCE(lead.""AppraisedValueOfProperties"", l.""AppraisedValueOfProperties"")
			                ,""ModifiedOn"" = LOCALTIMESTAMP
			                ,""ModifiedById"" = p_system_user_id 
		                 FROM lead
		                 WHERE l.""Id"" = lead.""LeadId""
		 	                AND (l.""AppraisedValueOfProperties"" IS DISTINCT FROM COALESCE(lead.""AppraisedValueOfProperties"", l.""AppraisedValueOfProperties"")
		 		                OR l.""TotalAmountDueProperties"" IS DISTINCT FROM COALESCE(lead.""TotalAmountDueProperties"", l.""TotalAmountDueProperties""));
		 	
		                GET DIAGNOSTICS p_ucnt = ROW_COUNT;
		                p_utotal = p_utotal + COALESCE(p_ucnt, 0);
	
	
		                /* Update events OriginalListCount and OriginalListAmount */
		                WITH ue AS
		                (
			                SELECT DISTINCT ""EventId""
			                FROM main.""Delinquency"" d
			                WHERE ""EventId"" IS NOT NULL
				                AND EXISTS (SELECT 1 FROM main.""Property"" p
								                INNER JOIN stage.synergy_source_data sd on p.""PropertyBK"" = sd.property_bk
								                WHERE  p.""Id"" = d.""PropertyId"")
		                )
		                UPDATE main.""Event"" e SET 
				                ""OriginalListCount"" = res.""OriginalListCount""
				                ,""OriginalListAmount"" = res.""OriginalListAmount""
				                ,""ModifiedOn"" = LOCALTIMESTAMP
                                ,""ModifiedById"" = p_system_user_id
		                FROM (
				                SELECT d.""EventId"", count(*) AS ""OriginalListCount"", sum(d.""Amount"") AS ""OriginalListAmount""
				                FROM main.""Delinquency"" d
				                INNER JOIN ue ON d.""EventId"" = ue.""EventId""
				                GROUP by d.""EventId""
			                ) res
		                WHERE e.""Id"" = res.""EventId""
			                AND (e.""OriginalListCount"" IS DISTINCT FROM COALESCE(res.""OriginalListCount"", e.""OriginalListCount"")
				                  OR e.""OriginalListAmount"" IS DISTINCT FROM COALESCE(res.""OriginalListAmount"", e.""OriginalListAmount""));		               
		               
		                GET DIAGNOSTICS p_ucnt = ROW_COUNT;
		                p_utotal = p_utotal + COALESCE(p_ucnt, 0);
		 	

	                RETURN QUERY
	                SELECT p_utotal, 0::numeric;
							 
                END;
                $function$;
                ";

            migrationBuilder.Sql(sqlStageScript, true);

            string sqlSystemScript = @"
                /* create system schema */
                CREATE SCHEMA IF NOT EXISTS system;

                CREATE SEQUENCE IF NOT EXISTS system.step_id_seq;

                CREATE TABLE IF NOT EXISTS system.integration_log
                (
                    step_id numeric(18,0) NOT NULL DEFAULT nextval('system.step_id_seq'::regclass),
                    process_tree character varying(256) COLLATE pg_catalog.""default"" NOT NULL,
                    step_desc character varying(8000) COLLATE pg_catalog.""default"" NOT NULL,
                    step_status character varying(50) COLLATE pg_catalog.""default"" NOT NULL,
                    start_time timestamp without time zone NOT NULL,
                    stop_time timestamp without time zone,
                    error_message text COLLATE pg_catalog.""default"",
                    recs_inserted numeric(18,0),
                    recs_updated numeric(18,0),
                    recs_deleted numeric(18,0),
                    rec_error numeric(18,0),
                    is_root numeric(1,0) NOT NULL,
                    CONSTRAINT pk_integration_log PRIMARY KEY (step_id)
                );

                CREATE INDEX IF NOT EXISTS idx_integration_log
                    ON system.integration_log USING btree
                    (step_id)
                    TABLESPACE pg_default;
   
    
   
                /* DROP/CREATE log_step_start FUNCTION */
                DROP FUNCTION IF EXISTS system.log_step_start();

                CREATE OR REPLACE FUNCTION system.log_step_start(
	                p_parent_process_tree character varying,
	                p_step_desc character varying)
                    RETURNS TABLE(step_id numeric, process_tree character varying) 
                    LANGUAGE 'plpgsql'

                    COST 100
                    VOLATILE 
                    ROWS 1000
                AS $BODY$

                DECLARE  
                    p_step_id NUMERIC(18,0);
                    p_process_tree VARCHAR(256);
                    d_process_tree VARCHAR(256);
                    d_step_status VARCHAR(50);
                    d_start_time TIMESTAMP;
                    d_is_root NUMERIC(1,0);

                BEGIN

                    SELECT nextval('system.step_id_seq') INTO p_step_id;
    
                    IF (p_parent_process_tree IS null or p_parent_process_tree = '') THEN
                    BEGIN
                        p_process_tree = p_step_id::VARCHAR(256) || '.';
                        d_is_root = 1;
                    END;
                    ELSE
                    BEGIN
                        p_process_tree = p_parent_process_tree || p_step_id::VARCHAR(256) || '.';
                        d_is_root = 0;
                    END;
                    END IF;

                    d_step_status = 'IN PROGRESS';
                    d_start_time = CURRENT_TIMESTAMP;
   

                    INSERT INTO system.integration_log(step_id, process_tree, step_desc, step_status, start_time, is_root)
                    VALUES(p_step_id, p_process_tree, p_step_desc, d_step_status, d_start_time, d_is_root);

                    RETURN QUERY
                    SELECT p_step_id AS step_id, p_process_tree AS process_tree;

                END;
                $BODY$;


                /* DROP/CREATE log_step_stop FUNCTION */
                DROP FUNCTION IF EXISTS system.log_step_stop();

                CREATE OR REPLACE FUNCTION system.log_step_stop(
	                p_step_id numeric,
	                p_recs_inserted numeric DEFAULT NULL::numeric,
	                p_recs_updated numeric DEFAULT NULL::numeric,
	                p_recs_deleted numeric DEFAULT NULL::numeric,
	                p_rec_error numeric DEFAULT NULL::numeric)
                    RETURNS void
                    LANGUAGE 'plpgsql'

                    COST 100
                    VOLATILE 
                AS $BODY$

                BEGIN

                    UPDATE system.integration_log 
                    SET step_status = 'SUCCESS',
                    stop_time = CURRENT_TIMESTAMP,
                    recs_inserted = p_recs_inserted,
                    recs_updated = p_recs_updated,
                    recs_deleted = p_recs_deleted,
                    rec_error = p_rec_error
                    WHERE step_id = p_step_id;

                END;
                $BODY$;



                /* DROP/CREATE log_step_error FUNCTION */
                DROP FUNCTION IF EXISTS system.log_step_error();

                CREATE OR REPLACE FUNCTION system.log_step_error(
	                p_step_id numeric,
	                p_error_message character varying)
                    RETURNS void
                    LANGUAGE 'plpgsql'

                    COST 100
                    VOLATILE 
                AS $BODY$

                BEGIN

	                UPDATE system.integration_log SET 
		                step_status = 'ERROR',
		                stop_time = CURRENT_TIMESTAMP,
		                error_message = p_error_message
	                WHERE step_id = p_step_id;

                END;
                $BODY$;


                /* DROP/CREATE get_integration_log_step_details FUNCTION */
                DROP FUNCTION IF EXISTS system.get_integration_log_step_details(p_step_id numeric);

                CREATE OR REPLACE FUNCTION system.get_integration_log_step_details(p_step_id numeric)
                 RETURNS TABLE(step_id numeric, step_desc character varying, duration text, duration_sec integer, start_time timestamp without time zone, stop_time timestamp without time zone, recs_inserted numeric, recs_updated numeric, step_status character varying, error_message text)
                 LANGUAGE plpgsql
                AS $function$
	                DECLARE 
		                p_parent_tree_id text;
                BEGIN

	                SELECT SUBSTRING(process_tree FROM 1 FOR POSITION('.' IN process_tree)) INTO p_parent_tree_id
	                FROM ""system"".integration_log il 
	                WHERE il.step_id = p_step_id;
	
	                RETURN QUERY
	                SELECT il.step_id, il.step_desc,     			
		                 TO_CHAR((((DATE_PART('hour', il.stop_time::time - il.start_time::time) * 60 +
	               	                DATE_PART('minute', il.stop_time::time - il.start_time::time)) * 60 +
	               	                DATE_PART('second', il.stop_time::time - il.start_time::time))::integer || ' second')::interval, 'HH24:MI:SS') as duration,
	                       (EXTRACT(EPOCH FROM (il.stop_time - il.start_time)))::integer AS duration_sec,
	                       il.start_time, il.stop_time, il.recs_inserted, il.recs_updated, il.step_status, il.error_message            			
	                FROM ""system"".integration_log il
	                WHERE process_tree LIKE p_parent_tree_id || '%'
	                ORDER BY step_id ASC;
							 
                END;
                $function$;



                /* CREATE delete_audit_triggers FUNCTION 
                 * 
                 * p_schema_name: schema name;
                 * p_history_table_suffix: history tables suffix (Audit)
                 * p_delete_all: TRUE - delete all audit triggers and functions, FALSE (default) - delete triggers and functions for missing audit table only;
                 * 
                 * */
                CREATE OR REPLACE FUNCTION system.delete_audit_triggers(p_schema_name CHARACTER VARYING, p_history_table_suffix CHARACTER VARYING, p_delete_all BOOL DEFAULT FALSE)
                 RETURNS void
                 LANGUAGE plpgsql
                AS $function$
                DECLARE 	
	                s_drop_triggers text;
	                s_drop_functions text;
                BEGIN
	
	                SELECT string_agg(concat('DROP TRIGGER IF EXISTS ', tr.trigger_name, ' ON ', tr.event_object_schema, '.', quote_ident(tr.event_object_table), ';'), chr(10))
		                , string_agg(concat('DROP FUNCTION IF EXISTS ', RIGHT (tr.action_statement, length(tr.action_statement) - 18), ';'), chr(10))
		                INTO s_drop_triggers, s_drop_functions
	                FROM information_schema.triggers tr
		                LEFT JOIN information_schema.tables t ON tr.trigger_schema = t.table_schema AND concat(tr.event_object_table, p_history_table_suffix) = t.table_name
	                WHERE tr.trigger_schema = p_schema_name
		                AND (trigger_name LIKE '%_update_audit_trg' OR trigger_name LIKE '%_delete_audit_trg')
		                AND (p_delete_all OR t.table_name IS NULL);
    	
	                /* Delete triggers */
	                IF COALESCE(s_drop_triggers, '') <> '' THEN 
		                EXECUTE s_drop_triggers;
	                END IF;
			
	                /* Delete functions */
	                IF COALESCE(s_drop_functions, '') <> ''THEN 
		                EXECUTE s_drop_functions;
	                END IF;
						 
                END;
                $function$;



                /* DROP/CREATE create_audit_triggers FUNCTION */
                DROP FUNCTION IF EXISTS system.create_audit_triggers();

                CREATE OR REPLACE FUNCTION system.create_audit_triggers(p_schema_name character varying, p_history_table_suffix character varying, p_history_timestamp_column_name character varying)
                 RETURNS void
                 LANGUAGE plpgsql
                AS $function$
                DECLARE 	
	                r_table record;
	                s_or_columns_list text;
	                s_insert_columns_list text;
	                s_values_columns_list text;
                BEGIN
	
	                PERFORM system.delete_audit_triggers(p_schema_name, p_history_table_suffix);
	
                    FOR r_table IN SELECT table_name FROM information_schema.tables WHERE table_schema = p_schema_name AND table_name NOT LIKE CONCAT(p_history_table_suffix, '%')
                    LOOP
    
		                IF EXISTS(SELECT 1 FROM information_schema.tables WHERE table_schema = p_schema_name AND table_name = CONCAT(r_table.table_name, p_history_table_suffix))                                  
    	                THEN
    	    
    		                SELECT string_agg(concat('NEW.', quote_ident(s.column_name), ' <> ', 'OLD.', quote_ident(s.column_name)), ' OR ') INTO s_or_columns_list
			                FROM information_schema.columns s
				                INNER JOIN information_schema.columns d ON d.table_schema = p_schema_name
				                AND d.table_name = CONCAT(r_table.table_name, p_history_table_suffix) AND d.column_name = s.column_name                                      
			                WHERE s.table_schema = p_schema_name
			                  AND s.table_name   = r_table.table_name;
    	
    		                SELECT concat(string_agg(quote_ident(s.column_name), ','), ',', quote_ident(p_history_timestamp_column_name)) INTO s_insert_columns_list
			                FROM information_schema.columns s
				                INNER JOIN information_schema.columns d ON d.table_schema = p_schema_name
				                AND d.table_name = CONCAT(r_table.table_name, p_history_table_suffix) AND d.column_name = s.column_name                                      
			                WHERE s.table_schema = p_schema_name
			                  AND s.table_name   = r_table.table_name;
			  
    		                SELECT string_agg(concat('OLD.', quote_ident(s.column_name)), ', ') INTO s_values_columns_list   
			                FROM information_schema.columns s
				                INNER JOIN information_schema.columns d ON d.table_schema = p_schema_name
				                AND d.table_name = CONCAT(r_table.table_name, p_history_table_suffix) AND d.column_name = s.column_name                                      
			                WHERE s.table_schema = p_schema_name
			                  AND s.table_name   = r_table.table_name;
    	
    		                /* Create update audit trigger */
			                EXECUTE CONCAT('CREATE OR REPLACE FUNCTION ',  p_schema_name, '.audit_', lower(r_table.table_name),'_update() ', chr(10)
				                ,'RETURNS TRIGGER', chr(10)
				                ,'LANGUAGE plpgsql', chr(10)
				                ,'AS $BODY$', chr(10)
				                ,'BEGIN', chr(10)
				                ,'IF (', s_or_columns_list, ')', chr(10)
				                ,'THEN', chr(10)
				                ,'	INSERT INTO ', p_schema_name, '.""', r_table.table_name, p_history_table_suffix, '"" (', s_insert_columns_list, ')', chr(10)
				                ,'	VALUES(', s_values_columns_list, ',', 'clock_timestamp());', chr(10)
				                ,'END IF;', chr(10)
				                ,'RETURN NEW;', CHR(10)
				                ,'END;', chr(10)
				                ,'$BODY$;', chr(10), chr(10)
				
				                ,'DROP TRIGGER IF EXISTS ', lower(r_table.table_name), '_update_audit_trg ON ', p_schema_name, '.""', r_table.table_name, '"";', CHR(10)
				                ,'CREATE TRIGGER ', lower(r_table.table_name), '_update_audit_trg', CHR(10)
				                ,'AFTER UPDATE', chr(10)
				                ,'ON ', p_schema_name, '.""', r_table.table_name, '""', chr(10)
				                ,'FOR EACH ROW', chr(10)
				                ,'EXECUTE PROCEDURE ',  p_schema_name, '.audit_', lower(r_table.table_name),'_update();', chr(10)
				                );
			
			                /* Create delete audit trigger */
			                EXECUTE CONCAT('CREATE OR REPLACE FUNCTION ',  p_schema_name, '.audit_', lower(r_table.table_name),'_delete() ', chr(10)
				                ,'RETURNS TRIGGER', chr(10)
				                ,'LANGUAGE plpgsql', chr(10)
				                ,'AS $BODY$', chr(10)
				                ,'BEGIN', chr(10)
				                ,'	INSERT INTO ', p_schema_name, '.""', r_table.table_name, p_history_table_suffix, '"" (', s_insert_columns_list, ')', chr(10)
				                ,'	VALUES(', REPLACE(s_values_columns_list, 'OLD.""DeletedOn""', 'clock_timestamp()'), ',', 'clock_timestamp());', chr(10)
				                ,'RETURN NEW;', CHR(10)
				                ,'END;', chr(10)
				                ,'$BODY$;', chr(10), chr(10)
				
				                ,'DROP TRIGGER IF EXISTS ', lower(r_table.table_name), '_delete_audit_trg ON ', p_schema_name, '.""', r_table.table_name, '"";', CHR(10)
				                ,'CREATE TRIGGER ', lower(r_table.table_name), '_delete_audit_trg', CHR(10)
				                ,'AFTER DELETE', chr(10)
				                ,'ON ', p_schema_name, '.""', r_table.table_name, '""', chr(10)
				                ,'FOR EACH ROW', chr(10)
				                ,'EXECUTE PROCEDURE ',  p_schema_name, '.audit_', lower(r_table.table_name),'_delete();', chr(10)
				                );
						 
		                END IF;		
                    END LOOP;  
                END;
                $function$;




                /* DROP/CREATE html_table FUNCTION */
                DROP FUNCTION IF EXISTS system.html_table(query text);

                CREATE OR REPLACE FUNCTION system.html_table(query text)
                 RETURNS SETOF text
                 LANGUAGE plpgsql
                AS $function$
                DECLARE
                    rec record;
                    header boolean := true;
                BEGIN
    
                    FOR rec IN 
                        EXECUTE format($q$
                            SELECT row_to_json(q) json_row
                            FROM (%s) q
                            $q$, query)
                    LOOP
                        IF HEADER then
        	                RETURN NEXT '<table style=''font-family: Roboto,""Helvetica Neue"",sans-serif; font-size: 12px; font-weight: 500; width: 100%; color: rgba(0,0,0,.54); text-align: left;''>';
                            RETURN query SELECT 
                                format ('<tr><th>%s</th></tr>', string_agg(key, '</th><th>'))
                            FROM json_each(rec.json_row);
                            header := false;
                        END IF;
                        RETURN query SELECT 
                            format ('<tr><td>%s</td></tr>', string_agg(value, '</td><td>'))
                        FROM json_each_text(rec.json_row);
                    END LOOP;
                    IF not header 
   	                THEN 
  		                RETURN NEXT '</table>'; 
  	                END IF;
                END $function$;



                /* DROP/CREATE get_integration_log_mail_body FUNCTION */
                DROP FUNCTION IF EXISTS ""system"".get_integration_log_mail_body (p_step_id numeric, p_title text, p_error_message text, p_has_warnings boolean);

                CREATE OR REPLACE FUNCTION ""system"".get_integration_log_mail_body (p_step_id numeric, p_title text, p_error_message text, p_has_warnings boolean)
                RETURNS SETOF TEXT LANGUAGE plpgsql AS $$
                DECLARE
	                p_body text;
	                p_color text;
	                p_log_html_table text;
	                p_error_html text;
                BEGIN
	
	                p_color = '#3F51B5';
	                p_error_html = '';
	                p_error_message = COALESCE(p_error_message, '');

	                IF p_has_warnings
	                THEN
		                p_color = '	#FFCC00';
	
		                p_error_html =  CONCAT('<tr><td style=''border-top: 2px solid ', p_color, '; color: rgba(0,0,0,.54); padding: 10px''><span>', chr(10)
				                ,'ETL executed with warnings! For more details please take a look at the flat database.', chr(10)
				                ,'</span></td></tr>', chr(10));
	                END if;
	
	                IF p_error_message <> ''
	                THEN 
		                p_color = '#DF0101';
	
		                p_error_html =  CONCAT('<tr><td style=''border-top: 2px solid ', p_color, '; color: rgba(0,0,0,.54); padding: 10px''><span>', chr(10)
				                ,p_error_message, chr(10)
				                ,'</span></td></tr>', chr(10));
	
	                END IF;


	                SELECT '<tr><td>' || string_agg(html_table, ' ') || '</td></tr>' INTO p_log_html_table 
	                FROM ""system"".html_table(
	                'SELECT CASE step_desc 
				                WHEN ''Get_Entry_Data'' THEN ''Stage''
				                WHEN ''Upsert_Lead'' THEN ''Lead'' 
				                WHEN ''Upsert_Property'' THEN ''Property'' 
				                WHEN ''Upsert_PropertyValuation'' THEN ''Property Valuation'' 
				                WHEN ''Upsert_SupplementalEventData'' THEN ''Supplemental Event Data'' 
				                WHEN ''Upsert_Delinquency'' THEN ''Delinquency''
				                WHEN ''Refresh_Totals'' THEN ''Refresh Totals''  
		                   END AS ""Step Name""
		                ,start_time AS ""Start Time""
		                ,duration AS ""Duration""
		                ,recs_inserted AS ""Rows Inserted""
		                ,recs_updated AS ""Rows Updated""
	                FROM ""system"".get_integration_log_step_details(' || p_step_id::text || ')
	                WHERE step_desc IN (''Get_Entry_Data'', ''Upsert_Lead'', ''Upsert_Property'', ''Upsert_PropertyValuation'', ''Upsert_SupplementalEventData'', ''Upsert_Delinquency'', ''Refresh_Totals'')' 
	                );
	
	                p_body =  CONCAT('<table style=''border: 2px solid ' , p_color, '; width: 1000px;''>', chr(10)
		                ,'<tr><td style=''background: ', p_color, '; color: #fff; padding: 0 16px; align-items: center; font: 500 20px/32px Roboto,""Helvetica Neue"",sans-serif;''> ', chr(10)
		                ,'<span style=''padding-right:10px;'' >', p_step_id, '</span> ', chr(10)
		                ,'<span>', p_title, '</span> ', chr(10)
		                ,'</td></tr>', chr(10)
		                ,p_log_html_table, chr(10)
		                ,p_error_html, chr(10)
		                ,'</table>', chr(10)
	                );
	
                    RETURN NEXT p_body;
                END $$;    
            ";

            migrationBuilder.Sql(sqlSystemScript, true);
            migrationBuilder.Sql("SELECT system.create_audit_triggers('main', 'Audit', 'InsertedOn');", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
