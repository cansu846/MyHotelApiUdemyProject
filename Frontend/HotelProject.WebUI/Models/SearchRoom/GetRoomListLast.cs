namespace HotelProject.WebUI.Models.SearchRoom
{
    public class GetRoomListLast
    {

        public class Rootobject
        {
            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Block[] block { get; set; }
            public int address_required { get; set; }
            public int is_cpv2_property { get; set; }
            public Min_Room_Distribution min_room_distribution { get; set; }
            public int duplicate_rates_removed { get; set; }
            public string currency_code { get; set; }
            public string recommended_block_title { get; set; }
            public string departure_date { get; set; }
            public string arrival_date { get; set; }
            public int hotel_id { get; set; }
            public Top_Ufi_Benefits[] top_ufi_benefits { get; set; }
            public object[] soldout_rooms { get; set; }
            public Rooms rooms { get; set; }
            public int total_blocks { get; set; }
            public Property_Policy_Display_Details property_policy_display_details { get; set; }
            public int b_legal_use_neutral_color_for_persuasion_legal { get; set; }
            public int is_tpi_exclusive_property { get; set; }
            public int use_new_bui_icon_highlight { get; set; }
            public Direct_Payment direct_payment { get; set; }
            public string cvc_required { get; set; }
            public string cc_required { get; set; }
            public object[] tax_exceptions { get; set; }
            public Cancellation_Policies cancellation_policies { get; set; }
            public object[] preferences { get; set; }
            public int qualifies_for_no_cc_reservation { get; set; }
            public Prepayment_Policies prepayment_policies { get; set; }
            public Payment_Detail payment_detail { get; set; }
            public int last_matching_block_index { get; set; }
            public int max_rooms_in_reservation { get; set; }
            public string average_room_size_for_ufi_m2 { get; set; }
            public int opted_out_from_gallery_changes { get; set; }
        }

        public class Min_Room_Distribution
        {
            public int adults { get; set; }
            public int[] children { get; set; }
        }

        public class Rooms
        {
            public _711242709 _711242709 { get; set; }
            public _711242711 _711242711 { get; set; }
        }

        public class _711242709
        {
            public Children_And_Beds_Text children_and_beds_text { get; set; }
            public Cribs_Extra_Beds cribs_extra_beds { get; set; }
            public Ceb_Available ceb_available { get; set; }
            public string description { get; set; }
            public Facility[] facilities { get; set; }
            public Private_Bathroom_Highlight private_bathroom_highlight { get; set; }
            public Photo[] photos { get; set; }
            public int private_bathroom_count { get; set; }
            public Highlight[] highlights { get; set; }
            public Bed_Configurations[] bed_configurations { get; set; }
        }

        public class Children_And_Beds_Text
        {
            public int allow_children { get; set; }
            public Cribs_And_Extra_Beds[] cribs_and_extra_beds { get; set; }
            public Children_At_The_Property[] children_at_the_property { get; set; }
            public Age_Intervals[] age_intervals { get; set; }
        }

        public class Cribs_And_Extra_Beds
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Children_At_The_Property
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Age_Intervals
        {
            public Group_By_Price group_by_price { get; set; }
            public string[][] types_by_price { get; set; }
            public int max_age { get; set; }
            public Crib crib { get; set; }
            public int min_age { get; set; }
        }

        public class Group_By_Price
        {
            public string[] freeper_night0 { get; set; }
        }

        public class Crib
        {
            public string price_type { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
            public int price_type_n { get; set; }
            public string price_mode { get; set; }
            public int price { get; set; }
            public int guaranteed { get; set; }
        }

        public class Cribs_Extra_Beds
        {
            public Cribs cribs { get; set; }
        }

        public class Cribs
        {
            public int max_count { get; set; }
            public int all_free { get; set; }
            public int[] ages { get; set; }
        }

        public class Ceb_Available
        {
            public string icon { get; set; }
            public int free { get; set; }
            public string text { get; set; }
            public string guaranteed { get; set; }
        }

        public class Private_Bathroom_Highlight
        {
            public int has_highlight { get; set; }
        }

        public class Facility
        {
            public int alt_facilitytype_id { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int facilitytype_id { get; set; }
        }

        public class Photo
        {
            public string url_original { get; set; }
            public string url_square60 { get; set; }
            public string last_update_date { get; set; }
            public string url_square180 { get; set; }
            public string url_max750 { get; set; }
            public string url_max300 { get; set; }
            public string url_640x200 { get; set; }
            public float ratio { get; set; }
            public int photo_id { get; set; }
            public string url_max1280 { get; set; }
        }

        public class Highlight
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
            public int id { get; set; }
        }

        public class Bed_Configurations
        {
            public Bed_Types[] bed_types { get; set; }
        }

        public class Bed_Types
        {
            public object description_localized { get; set; }
            public string name { get; set; }
            public int bed_type { get; set; }
            public string description_imperial { get; set; }
            public int count { get; set; }
            public string name_with_count { get; set; }
            public string description { get; set; }
        }

        public class _711242711
        {
            public int private_bathroom_count { get; set; }
            public Photo1[] photos { get; set; }
            public Private_Bathroom_Highlight1 private_bathroom_highlight { get; set; }
            public Highlight1[] highlights { get; set; }
            public Bed_Configurations1[] bed_configurations { get; set; }
            public Apartment_Configuration[] apartment_configuration { get; set; }
            public Children_And_Beds_Text1 children_and_beds_text { get; set; }
            public Cribs_Extra_Beds1 cribs_extra_beds { get; set; }
            public string description { get; set; }
            public Facility1[] facilities { get; set; }
            public Ceb_Available1 ceb_available { get; set; }
        }

        public class Private_Bathroom_Highlight1
        {
            public int has_highlight { get; set; }
        }

        public class Children_And_Beds_Text1
        {
            public Cribs_And_Extra_Beds1[] cribs_and_extra_beds { get; set; }
            public int allow_children { get; set; }
            public Age_Intervals1[] age_intervals { get; set; }
            public Children_At_The_Property1[] children_at_the_property { get; set; }
        }

        public class Cribs_And_Extra_Beds1
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Age_Intervals1
        {
            public Extra_Bed extra_bed { get; set; }
            public string[][] types_by_price { get; set; }
            public Group_By_Price1 group_by_price { get; set; }
            public int max_age { get; set; }
            public int min_age { get; set; }
            public Crib1 crib { get; set; }
        }

        public class Extra_Bed
        {
            public int price { get; set; }
            public int id { get; set; }
            public int price_type_n { get; set; }
            public string price_type { get; set; }
            public string price_mode { get; set; }
            public int price_mode_n { get; set; }
        }

        public class Group_By_Price1
        {
            public string[] freeper_night0 { get; set; }
        }

        public class Crib1
        {
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
            public int price { get; set; }
            public int guaranteed { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
        }

        public class Children_At_The_Property1
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Cribs_Extra_Beds1
        {
            public Extra_Beds extra_beds { get; set; }
            public Cribs1 cribs { get; set; }
            public int is_exclusive { get; set; }
        }

        public class Extra_Beds
        {
            public int all_free { get; set; }
            public int max_count { get; set; }
            public int[] ages { get; set; }
        }

        public class Cribs1
        {
            public int[] ages { get; set; }
            public int all_free { get; set; }
            public int max_count { get; set; }
        }

        public class Ceb_Available1
        {
            public string guaranteed { get; set; }
            public string text { get; set; }
            public int free { get; set; }
            public string icon { get; set; }
        }

        public class Photo1
        {
            public string url_original { get; set; }
            public string last_update_date { get; set; }
            public string url_square60 { get; set; }
            public string url_max750 { get; set; }
            public string url_640x200 { get; set; }
            public string url_square180 { get; set; }
            public string url_max300 { get; set; }
            public float ratio { get; set; }
            public int photo_id { get; set; }
            public string url_max1280 { get; set; }
        }

        public class Highlight1
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
            public int id { get; set; }
        }

        public class Bed_Configurations1
        {
            public Bed_Types1[] bed_types { get; set; }
        }

        public class Bed_Types1
        {
            public string name { get; set; }
            public int count { get; set; }
            public string name_with_count { get; set; }
            public string description { get; set; }
            public int bed_type { get; set; }
            public string description_imperial { get; set; }
        }

        public class Apartment_Configuration
        {
            public Apartment_Bed_Setup[] apartment_bed_setup { get; set; }
            public Room_Details[] room_details { get; set; }
        }

        public class Apartment_Bed_Setup
        {
            public int max_persons { get; set; }
            public string description { get; set; }
            public int ensuite_bathroom { get; set; }
            public string description_short { get; set; }
            public string desc_imperial { get; set; }
            public int bed_count { get; set; }
            public string desc_imperial_short { get; set; }
            public string name { get; set; }
            public string room_type { get; set; }
            public int room_id { get; set; }
            public string name_alternative { get; set; }
            public int apartment_room_id { get; set; }
            public string name_withnumber { get; set; }
            public int bedtype_id { get; set; }
        }

        public class Room_Details
        {
            public string room_type { get; set; }
            public int ensuite_bathroom { get; set; }
            public string room_type_translated { get; set; }
        }

        public class Facility1
        {
            public string alt_facilitytype_name { get; set; }
            public string name { get; set; }
            public int facilitytype_id { get; set; }
            public int id { get; set; }
            public int alt_facilitytype_id { get; set; }
            public string[] photos { get; set; }
        }

        public class Property_Policy_Display_Details
        {
            public object legal_cases { get; set; }
        }

        public class Direct_Payment
        {
            public int is_hpp_only { get; set; }
        }

        public class Cancellation_Policies
        {
            public string _711242709_353953973_2_1_0_814609 { get; set; }
            public string _711242711_353953973_1_1_0_814609 { get; set; }
            public string _711242711_353953973_2_1_0_814609 { get; set; }
        }

        public class Prepayment_Policies
        {
            public string _711242711_353953973_1_1_0_814609 { get; set; }
            public string _711242709_353953973_2_1_0_814609 { get; set; }
            public string _711242711_353953973_2_1_0_814609 { get; set; }
        }

        public class Payment_Detail
        {
            public string model { get; set; }
        }

        public class Block
        {
            public Transactional_Policy_Data transactional_policy_data { get; set; }
            public int extrabed_available { get; set; }
            public int max_children_free { get; set; }
            public B_Bsb_Campaigns[] b_bsb_campaigns { get; set; }
            public Block_Text block_text { get; set; }
            public int room_count { get; set; }
            public int number_of_bedrooms { get; set; }
            public int deposit_required { get; set; }
            public int room_id { get; set; }
            public int room_surface_in_m2 { get; set; }
            public string mealplan { get; set; }
            public Bundle_Extras bundle_extras { get; set; }
            public string block_id { get; set; }
            public int genius_discount_percentage { get; set; }
            public int is_domestic_rate { get; set; }
            public int fit_status { get; set; }
            public object is_genius_deal { get; set; }
            public float room_surface_in_feet2 { get; set; }
            public int roomtype_id { get; set; }
            public string is_block_fit { get; set; }
            public int pod_ios_migrate_policies_to_smp_fullon { get; set; }
            public Policy_Display_Details policy_display_details { get; set; }
            public int nr_adults { get; set; }
            public string name_without_policy { get; set; }
            public string nr_children { get; set; }
            public int refundable { get; set; }
            public object extrabed_available_amount { get; set; }
            public int smoking { get; set; }
            public int can_reserve_free_parking { get; set; }
            public string name { get; set; }
            public Sleeping_Clarity sleeping_clarity { get; set; }
            public Product_Price_Breakdown product_price_breakdown { get; set; }
            public int full_board { get; set; }
            public int max_children_free_age { get; set; }
            public string refundable_until { get; set; }
            public string max_occupancy { get; set; }
            public int pay_in_advance { get; set; }
            public int is_last_minute_deal { get; set; }
            public string room_name { get; set; }
            public Fit_Occupancy fit_occupancy { get; set; }
            public int is_dormitory { get; set; }
            public int nr_stays { get; set; }
            public int must_reserve_free_parking { get; set; }
            public int breakfast_included { get; set; }
            public object[] children_ages { get; set; }
            public Transactional_Policy_Objects[] transactional_policy_objects { get; set; }
            public object[] bh_room_highlights { get; set; }
            public int half_board { get; set; }
            public Paymentterms paymentterms { get; set; }
            public int babycots_available { get; set; }
            public int number_of_bathrooms { get; set; }
            public int is_flash_deal { get; set; }
            public int is_smart_deal { get; set; }
            public int all_inclusive { get; set; }
            public object babycots_available_amount { get; set; }
            public int package_id { get; set; }
        }

        public class Transactional_Policy_Data
        {
            public Booking_Conditions[] booking_conditions { get; set; }
            public string[] applied_products { get; set; }
            public Policy[] policies { get; set; }
        }

        public class Booking_Conditions
        {
            public string policy_type_key { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public string text { get; set; }
        }

        public class Policy
        {
            public string policy_type_key { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public string text { get; set; }
        }

        public class Block_Text
        {
            public Policy1[] policies { get; set; }
        }

        public class Policy1
        {
            public string content { get; set; }
            public string _class { get; set; }
            public string mealplan_vector { get; set; }
        }

        public class Bundle_Extras
        {
            public int bundle_id { get; set; }
            public string generated_name { get; set; }
            public string rich_value_add_page_title { get; set; }
            public string icon { get; set; }
            public string[] rich_footer { get; set; }
            public Benefit[] benefits { get; set; }
            public string has_rich_content { get; set; }
            public string highlighted_text { get; set; }
        }

        public class Benefit
        {
            public string[] details { get; set; }
            public string icon { get; set; }
            public string title { get; set; }
            public string name { get; set; }
        }

        public class Policy_Display_Details
        {
            public string[] applied_products { get; set; }
            public Prepayment prepayment { get; set; }
            public Cancellation cancellation { get; set; }
        }

        public class Prepayment
        {
            public Description_Details description_details { get; set; }
            public string policy_type_key { get; set; }
            public Title_Details title_details { get; set; }
            public string type { get; set; }
        }

        public class Description_Details
        {
            public string translation { get; set; }
            public string placeholder_translation { get; set; }
            public string tag { get; set; }
        }

        public class Title_Details
        {
            public string tag { get; set; }
            public string placeholder_translation { get; set; }
            public string translation { get; set; }
        }

        public class Cancellation
        {
            public string policy_type_key { get; set; }
            public Description_Details1 description_details { get; set; }
            public Parameters parameters { get; set; }
            public string type { get; set; }
            public Title_Details1 title_details { get; set; }
            public int is_cost_to_cancel { get; set; }
        }

        public class Description_Details1
        {
            public string translation { get; set; }
            public string placeholder_translation { get; set; }
        }

        public class Parameters
        {
            public int has_cancellation_fee { get; set; }
        }

        public class Title_Details1
        {
            public string translation { get; set; }
            public string placeholder_translation { get; set; }
            public string tag { get; set; }
        }

        public class Sleeping_Clarity
        {
            public Sleeping_Clarity_Description_Items[] sleeping_clarity_description_items { get; set; }
            public string sleeping_clarity_title { get; set; }
        }

        public class Sleeping_Clarity_Description_Items
        {
            public string text { get; set; }
            public string icon { get; set; }
        }

        public class Product_Price_Breakdown
        {
            public int nr_stays { get; set; }
            public Included_Taxes_And_Charges_Amount included_taxes_and_charges_amount { get; set; }
            public Excluded_Amount excluded_amount { get; set; }
            public Item[] items { get; set; }
            public Gross_Amount_Per_Night gross_amount_per_night { get; set; }
            public Benefit1[] benefits { get; set; }
            public Price_Display_Config[] price_display_config { get; set; }
            public int has_long_stays_weekly_rate_price { get; set; }
            public Net_Amount net_amount { get; set; }
            public int has_long_stays_monthly_rate_price { get; set; }
            public Strikethrough_Amount_Per_Night strikethrough_amount_per_night { get; set; }
            public Strikethrough_Amount strikethrough_amount { get; set; }
            public All_Inclusive_Amount_Hotel_Currency all_inclusive_amount_hotel_currency { get; set; }
            public Discounted_Amount discounted_amount { get; set; }
            public All_Inclusive_Amount all_inclusive_amount { get; set; }
            public Charges_Details charges_details { get; set; }
            public Gross_Amount_Hotel_Currency gross_amount_hotel_currency { get; set; }
            public Gross_Amount gross_amount { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
        }

        public class Excluded_Amount
        {
            public int value { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount_Per_Night
        {
            public string amount_rounded { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
        }

        public class Net_Amount
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Strikethrough_Amount_Per_Night
        {
            public string amount_rounded { get; set; }
            public int value { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Strikethrough_Amount
        {
            public string amount_rounded { get; set; }
            public int value { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class All_Inclusive_Amount_Hotel_Currency
        {
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
        }

        public class Discounted_Amount
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class All_Inclusive_Amount
        {
            public string amount_rounded { get; set; }
            public float value { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Charges_Details
        {
            public string translated_copy { get; set; }
            public Amount amount { get; set; }
            public string mode { get; set; }
        }

        public class Amount
        {
            public string currency { get; set; }
            public int value { get; set; }
        }

        public class Gross_Amount_Hotel_Currency
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Gross_Amount
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Item
        {
            public Base _base { get; set; }
            public string name { get; set; }
            public string kind { get; set; }
            public string details { get; set; }
            public Item_Amount item_amount { get; set; }
            public string inclusion_type { get; set; }
            public string identifier { get; set; }
        }

        public class Base
        {
            public int percentage { get; set; }
            public string kind { get; set; }
        }

        public class Item_Amount
        {
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class Benefit1
        {
            public string details { get; set; }
            public string identifier { get; set; }
            public object icon { get; set; }
            public string badge_variant { get; set; }
            public string kind { get; set; }
            public string name { get; set; }
        }

        public class Price_Display_Config
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class Fit_Occupancy
        {
            public int nr_adults { get; set; }
            public object[] children_ages { get; set; }
        }

        public class Paymentterms
        {
            public Cancellation1 cancellation { get; set; }
            public Prepayment1 prepayment { get; set; }
        }

        public class Cancellation1
        {
            public string description { get; set; }
            public string type_translation { get; set; }
            public Info info { get; set; }
            public int guaranteed_non_refundable { get; set; }
            public string bucket { get; set; }
            public string type { get; set; }
            public int non_refundable_anymore { get; set; }
        }

        public class Info
        {
            public object timezone_offset { get; set; }
            public object refundable_date { get; set; }
            public int refundable { get; set; }
            public object date { get; set; }
            public object date_raw { get; set; }
            public object date_before_raw { get; set; }
            public object time { get; set; }
            public object timezone { get; set; }
            public object date_before { get; set; }
            public object time_before_midnight { get; set; }
            public object is_midnight { get; set; }
        }

        public class Prepayment1
        {
            public Info1 info { get; set; }
            public string type { get; set; }
            public string simple_translation { get; set; }
            public string type_extended { get; set; }
            public string extended_type_translation { get; set; }
            public string description { get; set; }
            public string type_translation { get; set; }
        }

        public class Info1
        {
            public string refundable { get; set; }
            public object time { get; set; }
            public object date_before { get; set; }
            public object timezone { get; set; }
            public object date { get; set; }
            public object timezone_offset { get; set; }
            public int prepayment_at_booktime { get; set; }
            public object time_before_midnight { get; set; }
            public object is_midnight { get; set; }
        }

        public class B_Bsb_Campaigns
        {
            public int b_is_bsb { get; set; }
        }

        public class Transactional_Policy_Objects
        {
            public string icon { get; set; }
            public string text { get; set; }
            public string key { get; set; }
        }

        public class Top_Ufi_Benefits
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
        }

    }
}
