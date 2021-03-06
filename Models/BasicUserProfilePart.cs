using Orchard.ContentManagement;

namespace Codesanook.Users.Models {

    public class BasicUserProfilePart : ContentPart<BasicUserProfilePartRecord> {
        // https://english.stackexchange.com/a/78896
        public string FirstName {
            get => Record.FirstName;
            set => Record.FirstName = value;
        }

        public string LastName {
            get => Record.LastName;
            set => Record.LastName = value;
        }

        public string MobilePhoneNumber {
            get => Record.MobilePhoneNumber;
            set => Record.MobilePhoneNumber = value;
        }

        public string OrganizationName {
            get => Record.OrganizationName;
            set => Record.OrganizationName = value;
        }
    }
}