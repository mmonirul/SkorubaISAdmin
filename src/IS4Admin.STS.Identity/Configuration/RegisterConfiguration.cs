using IS4Admin.STS.Identity.Configuration.Intefaces;

namespace IS4Admin.STS.Identity.Configuration
{
    public class RegisterConfiguration : IRegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
    }
}
