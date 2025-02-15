using MatchingAPI.Data;
using MatchingAPI.Data.Entity;
using MatchingAPI.DTO;
using MatchingAPI.Helper;
using MatchingAPI.IServices;
using Microsoft.EntityFrameworkCore;

namespace MatchingAPI.Services
{
    public class Preference : IPreferenceInfo
    {

        private readonly PeopleDeskContext _dbContext;

        public Preference(PeopleDeskContext dbContext)
        {
          _dbContext = dbContext;
        }

        public async Task<CustomizeHelper> CreateUserPreferenceInfo(UserPreferenceDTO preference)
        {
            CustomizeHelper msg = new CustomizeHelper();

            if (preference == null)
            {
                msg.Message = "Invalid input data";
                msg.statuscode = 400;
                return msg;
            }

            try
            {
            
               var existingPreference = await _dbContext.TblUserPreferenceSummeries
                   .Where(x => x.IntUnitId==preference.UnitId && x.IsActive==true)
                   .FirstOrDefaultAsync();

                if (existingPreference != null)
                {
                    msg.Message = "User preference already exists.";
                    msg.statuscode = 400;
                    return msg;
                }

              
               var newPreference = new TblUserPreferenceSummery
               {
                   IntUnitId = preference.UnitId,
                   IntAgeMin = preference.AgeMin,
                   IntAgeMax = preference.AgeMax,
                   DecHeightMin = preference.DecHeightMin,
                   DecHeightMax = preference.DecHeightMax,
                   IntMaritalStatusId = preference.MaritalStatusId,
                   IntReligionId = preference.ReligionId,
                   IsCommunitPreperence = preference.IsCommunitPreperence,
                   IntCommunityId = preference.CommunityId,
                   IntSubCommunityId = preference.SubCommunityId,
                   IntCountryId = preference.CountryId,
                   IntDistrictId = preference.DistrictId,
                   IntThanaId = preference.ThanaId,
                   IntResidencyStatusId = preference.ResidencyStatusId,
                   IntHighestQualificationId = preference.HighestQualificationId,
                   IntWorkDesignationId = preference.WorkDesignationId,
                   IntWorkIndustryId = preference.WorkIndustryId,
                   DecAnnualIncomeMin = preference.DecAnnualIncomeMin,
                   DecAnnualIncomeMax = preference.DecAnnualIncomeMax,
                   StrDiet = preference.StrDiet,
                   StrHobbiesAndInterests = preference.StrHobbiesAndInterests,
                   IntMotherOccupationId = preference.MotherOccupationId,
                   IntFatherOccupationId = preference.FatherOccupationId,
                   IntNoOfSisters = preference.NoOfSisters,
                   IntNoOfBrothers = preference.NoOfBrothers,
                   IsActive = preference.IsActive,
                   DteCreatedDate = DateTime.Now,
                   DteUpdatedDate = DateTime.Now
               };

                await _dbContext.TblUserPreferenceSummeries.AddAsync(newPreference);
                await _dbContext.SaveChangesAsync();

                msg.Message = "User preference inserted successfully.";
                msg.statuscode = 200;
            }
            catch (Exception ex)
            {
                msg.Message = $"Error: {ex.Message}";
                msg.statuscode = 500;
            }

            return msg;
        }


    }
}
