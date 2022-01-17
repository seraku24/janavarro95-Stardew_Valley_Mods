using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegasis.HappyBirthday.Framework.Constants
{
    public static class MailKeys
    {
        public const string MAIL_KEY_PREFIX = "Omegasis.HappyBirthday_";

        public static readonly string MomBirthdayMessageKey = CreateMailKey("Mom");
        public static readonly string DadBirthdayMessageKey = CreateMailKey("Dad");
        public static readonly string JunimosBirthdayMessageKey = CreateMailKey("Junimos");

        public static readonly string DatingPenny_PartyInvite = CreateDatingPartyInvitationKey("Penny");
        public static readonly string DatingMaru_PartyInvite = CreateDatingPartyInvitationKey("Maru");
        public static readonly string DatingLeah_PartyInvite = CreateDatingPartyInvitationKey("Leah");
        public static readonly string DatingAbigail_PartyInvite = CreateDatingPartyInvitationKey("Abigail");
        public static readonly string DatingAbigail_PartyInvite_Wednesday = CreateDatingPartyInvitationKey("Abigail", "_Wednesday");
        public static readonly string DatingEmily_PartyInvite = CreateDatingPartyInvitationKey("Emily");
        public static readonly string DatingHaley_PartyInvite = CreateDatingPartyInvitationKey("Haley");

        public static readonly string DatingHarvey_PartyInvite = CreateDatingPartyInvitationKey("Harvey");
        public static readonly string DatingElliott_PartyInvite = CreateDatingPartyInvitationKey("Elliott");
        public static readonly string DatingSam_PartyInvite = CreateDatingPartyInvitationKey("Sam");
        public static readonly string DatingAlex_PartyInvite = CreateDatingPartyInvitationKey("Alex");
        public static readonly string DatingShane_PartyInvite = CreateDatingPartyInvitationKey("Shane");
        public static readonly string DatingSebastian_PartyInvite = CreateDatingPartyInvitationKey("Sebastian");

        public static string CreateMailKey(string MailKeySuffix)
        {
            return MAIL_KEY_PREFIX + MailKeySuffix;
        }

        /// <summary>
        /// Returns all of the mail keys for all pieces of mail expect the player's parents since those have custom logic.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllMailKeysExcludingParents()
        {
            List<string> mailKeys = GetAllDatingBirthdayPartyInviteMailKeys();
            mailKeys.AddRange(new List<string>()
            {
                JunimosBirthdayMessageKey
            });
            return mailKeys;
        }

        /// <summary>
        /// Gets all of the mail keys for the aprty invites form the datable npcs.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllDatingBirthdayPartyInviteMailKeys()
        {
            return new List<string>() {
                DatingPenny_PartyInvite,
                DatingMaru_PartyInvite,
                DatingLeah_PartyInvite,
                DatingAbigail_PartyInvite,
                DatingAbigail_PartyInvite_Wednesday,
                DatingEmily_PartyInvite,
                DatingHaley_PartyInvite,
                DatingHarvey_PartyInvite,
                DatingElliott_PartyInvite,
                DatingSam_PartyInvite,
                DatingAlex_PartyInvite,
                DatingShane_PartyInvite,
                DatingSebastian_PartyInvite
            };
        }

        /// <summary>
        /// Gets all mail keys possible.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllMailKeys()
        {
            List<string> allMailKeys = GetAllMailKeysExcludingParents();
            allMailKeys.AddRange(new List<string>()
            {
                MomBirthdayMessageKey,
                DadBirthdayMessageKey

            });
            return allMailKeys;
        }

        public static string CreateDatingPartyInvitationKey(string NPCName, string AdditionalSuffix = "")
        {
            string suffix = "Dating" + NPCName + "_BirthdayPartyInvitation" + AdditionalSuffix;
            return CreateMailKey(suffix);
        }
    }
}
