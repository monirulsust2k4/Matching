using MatchingAPI.Data.Entity;

namespace MatchingAPI.DTO
{
    public class UserPreferenceDTO
    {

        public long UsererenceId { get; set; }

        public long UserId { get; set; }

        public long UnitId { get; set; }

        public long AgeMin { get; set; }

        public long AgeMax { get; set; }

        public decimal? DecHeightMin { get; set; }

        public decimal? DecHeightMax { get; set; }

        public long? MaritalStatusId { get; set; }

        public long? ReligionId { get; set; }

        public bool? IsCommunitPreperence { get; set; }

        public long? CommunityId { get; set; }

        public long? SubCommunityId { get; set; }

        public long? CountryId { get; set; }

        public long? DistrictId { get; set; }

        public long? ThanaId { get; set; }

        public long? ResidencyStatusId { get; set; }

        public long? HighestQualificationId { get; set; }

        public long? WorkDesignationId { get; set; }

        public long? WorkIndustryId { get; set; }

        public decimal? DecAnnualIncomeMin { get; set; }

        public decimal? DecAnnualIncomeMax { get; set; }

        public string? StrDiet { get; set; }

        public string? StrHobbiesAndInterests { get; set; }

        public long? MotherOccupationId { get; set; }

        public long? FatherOccupationId { get; set; }

        public long? NoOfSisters { get; set; }

        public long? NoOfBrothers { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DteCreatedDate { get; set; }

        public DateTime? DteUpdatedDate { get; set; }

    }

    public class UserPreferredCommunityDTO()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntCommunityId { get; set; }
    }

    public  class UserPreferredCountry()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntCountryId { get; set; }

      
    }
    public  class UserPreferredDiet()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntDietId { get; set; }

        
    }


    public  class UserPreferredHobby()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntHobbyId { get; set; }

      
    }

    public  class UserPreferredMaritalStatus()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntMaritalStatusId { get; set; }

      
    }

    public  class UserPreferredQualification()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntQualificationId { get; set; }

       
    }


    public  class UserPreferredResidencyStatus()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntResidencyId { get; set; }

      
    }

    public  class UserPreferredSubCommunity()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntSubCommunityId { get; set; }

      
    }
    public  class UserPreferredWorkDesignation()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntDesignationId { get; set; }

       
    }
    public  class UserPreferredWorkIndustry()
    {
        public long IntId { get; set; }

        public long IntUserPreferenceId { get; set; }

        public long IntWorkIndustryId { get; set; }

        
    }
   

}
