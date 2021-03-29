using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProGraphGroup.InstagramPro.Core.Model.Core
{
    public class User
    {
        [JsonProperty("pk")] public int Pk { get; set; }

        [JsonProperty("username")] public string Username { get; set; }

        [JsonProperty("full_name")] public string FullName { get; set; }

        [JsonProperty("is_private")] public bool IsPrivate { get; set; }

        [JsonProperty("profile_pic_url")] public string ProfilePicUrl { get; set; }

        [JsonProperty("profile_pic_id")] public string ProfilePicId { get; set; }

        [JsonProperty("is_verified")] public bool IsVerified { get; set; }

        [JsonProperty("has_anonymous_profile_picture")]
        public bool HasAnonymousProfilePicture { get; set; }

        [JsonProperty("media_count")] public int MediaCount { get; set; }

        [JsonProperty("geo_media_count")] public int GeoMediaCount { get; set; }

        [JsonProperty("follower_count")] public int FollowerCount { get; set; }

        [JsonProperty("following_count")] public int FollowingCount { get; set; }

        [JsonProperty("following_tag_count")] public int FollowingTagCount { get; set; }

        [JsonProperty("biography")] public string Biography { get; set; }

        [JsonProperty("can_link_entities_in_bio")]
        public bool CanLinkEntitiesInBio { get; set; }

        [JsonProperty("biography_with_entities")]
        public BiographyWithEntities BiographyWithEntities { get; set; }

        [JsonProperty("biography_product_mentions")]
        public List<object> BiographyProductMentions { get; set; }

        [JsonProperty("external_url")] public string ExternalUrl { get; set; }

        [JsonProperty("can_boost_post")] public bool CanBoostPost { get; set; }

        [JsonProperty("can_see_organic_insights")]
        public bool CanSeeOrganicInsights { get; set; }

        [JsonProperty("show_insights_terms")] public bool ShowInsightsTerms { get; set; }

        [JsonProperty("can_convert_to_business")]
        public bool CanConvertToBusiness { get; set; }

        [JsonProperty("can_create_sponsor_tags")]
        public bool CanCreateSponsorTags { get; set; }

        [JsonProperty("is_allowed_to_create_standalone_nonprofit_fundraisers")]
        public bool IsAllowedToCreateStandaloneNonprofitFundraisers { get; set; }

        [JsonProperty("is_allowed_to_create_standalone_personal_fundraisers")]
        public bool IsAllowedToCreateStandalonePersonalFundraisers { get; set; }

        [JsonProperty("can_create_new_standalone_fundraiser")]
        public bool CanCreateNewStandaloneFundraiser { get; set; }

        [JsonProperty("can_create_new_standalone_personal_fundraiser")]
        public bool CanCreateNewStandalonePersonalFundraiser { get; set; }

        [JsonProperty("can_be_tagged_as_sponsor")]
        public bool CanBeTaggedAsSponsor { get; set; }

        [JsonProperty("can_see_support_inbox")]
        public bool CanSeeSupportInbox { get; set; }

        [JsonProperty("can_see_support_inbox_v1")]
        public bool CanSeeSupportInboxV1 { get; set; }

        [JsonProperty("total_igtv_videos")] public int TotalIgtvVideos { get; set; }

        [JsonProperty("has_igtv_series")] public bool HasIgtvSeries { get; set; }

        [JsonProperty("has_saved_items")] public bool HasSavedItems { get; set; }

        [JsonProperty("total_ar_effects")] public int TotalArEffects { get; set; }

        [JsonProperty("reel_auto_archive")] public string ReelAutoArchive { get; set; }

        [JsonProperty("is_profile_action_needed")]
        public bool IsProfileActionNeeded { get; set; }

        [JsonProperty("usertags_count")] public int UsertagsCount { get; set; }

        [JsonProperty("usertag_review_enabled")]
        public bool UsertagReviewEnabled { get; set; }

        [JsonProperty("is_needy")] public bool IsNeedy { get; set; }

        [JsonProperty("is_interest_account")] public bool IsInterestAccount { get; set; }

        [JsonProperty("has_chaining")] public bool HasChaining { get; set; }

        [JsonProperty("hd_profile_pic_versions")]
        public List<HdProfilePicVersion> HdProfilePicVersions { get; set; }

        [JsonProperty("hd_profile_pic_url_info")]
        public HdProfilePicUrlInfo HdProfilePicUrlInfo { get; set; }

        [JsonProperty("has_placed_orders")] public bool HasPlacedOrders { get; set; }

        [JsonProperty("can_tag_products_from_merchants")]
        public bool CanTagProductsFromMerchants { get; set; }

        [JsonProperty("fbpay_experience_enabled")]
        public bool FbpayExperienceEnabled { get; set; }

        [JsonProperty("show_conversion_edit_entry")]
        public bool ShowConversionEditEntry { get; set; }

        [JsonProperty("aggregate_promote_engagement")]
        public bool AggregatePromoteEngagement { get; set; }

        [JsonProperty("allowed_commenter_type")]
        public string AllowedCommenterType { get; set; }

        [JsonProperty("is_video_creator")] public bool IsVideoCreator { get; set; }

        [JsonProperty("has_profile_video_feed")]
        public bool HasProfileVideoFeed { get; set; }

        [JsonProperty("has_highlight_reels")] public bool HasHighlightReels { get; set; }

        [JsonProperty("has_guides")] public bool HasGuides { get; set; }

        [JsonProperty("is_eligible_to_show_fb_cross_sharing_nux")]
        public bool IsEligibleToShowFbCrossSharingNux { get; set; }

        [JsonProperty("page_id_for_new_suma_biz_account")]
        public string PageIdForNewSumaBizAccount { get; set; }

        [JsonProperty("eligible_shopping_signup_entrypoints")]
        public List<object> EligibleShoppingSignupEntrypoints { get; set; }

        [JsonProperty("service_shop_onboarding_status")]
        public object ServiceShopOnboardingStatus { get; set; }

        [JsonProperty("service_shop_merchant_entrypoint_app_id")]
        public string ServiceShopMerchantEntrypointAppId { get; set; }

        [JsonProperty("can_be_reported_as_fraud")]
        public bool CanBeReportedAsFraud { get; set; }

        [JsonProperty("is_business")] public bool IsBusiness { get; set; }

        [JsonProperty("account_type")] public int AccountType { get; set; }

        [JsonProperty("professional_conversion_suggested_account_type")]
        public int ProfessionalConversionSuggestedAccountType { get; set; }

        [JsonProperty("is_call_to_action_enabled")]
        public object IsCallToActionEnabled { get; set; }

        [JsonProperty("interop_messaging_user_fbid")]
        public long InteropMessagingUserFbid { get; set; }

        [JsonProperty("linked_fb_info")] public LinkedFbInfo LinkedFbInfo { get; set; }

        [JsonProperty("standalone_fundraiser_info")]
        public StandaloneFundraiserInfo StandaloneFundraiserInfo { get; set; }

        [JsonProperty("allow_mention_setting")]
        public string AllowMentionSetting { get; set; }

        [JsonProperty("allow_tag_setting")] public string AllowTagSetting { get; set; }

        [JsonProperty("can_see_primary_country_in_settings")]
        public bool CanSeePrimaryCountryInSettings { get; set; }

        [JsonProperty("personal_account_ads_page_name")]
        public string PersonalAccountAdsPageName { get; set; }

        [JsonProperty("personal_account_ads_page_id")]
        public string PersonalAccountAdsPageId { get; set; }

        [JsonProperty("account_badges")] public List<object> AccountBadges { get; set; }

        [JsonProperty("whatsapp_number")] public string WhatsappNumber { get; set; }

        [JsonProperty("has_eligible_whatsapp_linking_category")]
        public object HasEligibleWhatsappLinkingCategory { get; set; }

        [JsonProperty("fbid_v2")] public long FbidV2 { get; set; }

        [JsonProperty("is_eligible_for_appointment_creation_in_direct_thread")]
        public bool IsEligibleForAppointmentCreationInDirectThread { get; set; }

        [JsonProperty("include_direct_blacklist_status")]
        public bool IncludeDirectBlacklistStatus { get; set; }

        [JsonProperty("can_follow_hashtag")] public bool CanFollowHashtag { get; set; }

        [JsonProperty("is_potential_business")]
        public bool IsPotentialBusiness { get; set; }

        [JsonProperty("show_post_insights_entry_point")]
        public bool ShowPostInsightsEntryPoint { get; set; }

        [JsonProperty("feed_post_reshare_disabled")]
        public bool FeedPostReshareDisabled { get; set; }

        [JsonProperty("besties_count")] public int BestiesCount { get; set; }

        [JsonProperty("show_besties_badge")] public bool ShowBestiesBadge { get; set; }

        [JsonProperty("recently_bestied_by_count")]
        public int RecentlyBestiedByCount { get; set; }

        [JsonProperty("nametag")] public Nametag Nametag { get; set; }

        [JsonProperty("existing_user_age_collection_enabled")]
        public bool ExistingUserAgeCollectionEnabled { get; set; }

        [JsonProperty("about_your_account_bloks_entrypoint_enabled")]
        public bool AboutYourAccountBloksEntrypointEnabled { get; set; }

        [JsonProperty("auto_expand_chaining")] public bool AutoExpandChaining { get; set; }

        [JsonProperty("highlight_reshare_disabled")]
        public bool HighlightReshareDisabled { get; set; }

        [JsonProperty("is_memorialized")] public bool IsMemorialized { get; set; }

        [JsonProperty("open_external_url_with_in_app_browser")]
        public bool OpenExternalUrlWithInAppBrowser { get; set; }
    }

    public class BiographyWithEntities
    {
        [JsonProperty("raw_text")] public string RawText { get; set; }

        [JsonProperty("entities")] public List<object> Entities { get; set; }
    }

    public class HdProfilePicVersion
    {
        [JsonProperty("width")] public int Width { get; set; }

        [JsonProperty("height")] public int Height { get; set; }

        [JsonProperty("url")] public string Url { get; set; }
    }

    public class HdProfilePicUrlInfo
    {
        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("width")] public int Width { get; set; }

        [JsonProperty("height")] public int Height { get; set; }
    }

    public class LinkedFbUser
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("is_valid")] public bool IsValid { get; set; }
    }

    public class LinkedFbInfo
    {
        [JsonProperty("linked_fb_user")] public LinkedFbUser LinkedFbUser { get; set; }
    }

    public class StandaloneFundraiserInfo
    {
        [JsonProperty("has_active_fundraiser")]
        public bool HasActiveFundraiser { get; set; }

        [JsonProperty("fundraiser_id")] public object FundraiserId { get; set; }

        [JsonProperty("fundraiser_title")] public object FundraiserTitle { get; set; }

        [JsonProperty("fundraiser_type")] public object FundraiserType { get; set; }

        [JsonProperty("formatted_goal_amount")]
        public object FormattedGoalAmount { get; set; }

        [JsonProperty("beneficiary_username")] public object BeneficiaryUsername { get; set; }

        [JsonProperty("formatted_fundraiser_progress_info_text")]
        public object FormattedFundraiserProgressInfoText { get; set; }

        [JsonProperty("percent_raised")] public object PercentRaised { get; set; }
    }

    public class Nametag
    {
        [JsonProperty("mode")] public int Mode { get; set; }

        [JsonProperty("gradient")] public int Gradient { get; set; }

        [JsonProperty("emoji")] public string Emoji { get; set; }

        [JsonProperty("selfie_sticker")] public int SelfieSticker { get; set; }
    }
}