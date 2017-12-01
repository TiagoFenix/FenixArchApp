using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BasicTestApp.DataStore.Schema
{

    public class AccountDataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AccountId { get; set; }

        [MaxLength(250)]
        public string AccountName { get; set; }

        public DateTime Created { get; set; }

        [MaxLength(100)]
        public string CreatedBy { get; set; }
    }
}
