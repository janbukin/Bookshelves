using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Bookshelves.Data.EF.Conventions
{
    public class GuidIdentityConvention: Convention
    {
        public GuidIdentityConvention()
        {
            Properties<Guid>()
                .Where(x => x.Name == "Id")
                .Configure(x => x.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));
        }
    }
}
