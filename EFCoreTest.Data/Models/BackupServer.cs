using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTest.Data
{
    public class BackupServer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        [NotMapped]
        public int IgnoredProperty { get; set; }
    }
}