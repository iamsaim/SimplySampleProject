using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service.Core.Entities
{
    public class CompanyEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public int OwnerId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public string Currency { get; set; }
        public int AllowedUsers { get; set; }
        public bool AllowSupervisor { get; set; }
        public DateTimeOffset ContractSignedDate { get; set; }
        public DateTimeOffset ContractExpiryDate { get; set; }
        public string ContractUrl { get; set; }
        public int StorageLimit { get; set; }
        public string Notes { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
