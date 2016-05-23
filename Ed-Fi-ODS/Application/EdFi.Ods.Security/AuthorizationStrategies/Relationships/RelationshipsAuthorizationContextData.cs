namespace EdFi.Ods.Security.AuthorizationStrategies.Relationships
{
    /// <summary>
    /// Contains the pertinent Ed-Fi data necessary for making authorization decisions.
    /// </summary>
    public class RelationshipsAuthorizationContextData
    {
        // Education Organizations
        public int? EducationOrganizationId { get; set; }
        public int? StateEducationAgencyId { get; set; }
        public int? EducationServiceCenterId { get; set; }
        public int? LocalEducationAgencyId { get; set; }
        public int? SchoolId { get; set; }
        public int? EducationOrganizationNetworkId { get; set; }

        // People
        public int? StaffUSI { get; set; }
        public int? StudentUSI { get; set; }
        public int? ParentUSI { get; set; }

        // Education Organization Type (set after resolved to concrete type id)
        public string ConcreteEducationOrganizationIdPropertyName { get; set; }

        public virtual RelationshipsAuthorizationContextData Clone()
        {
            var clone = (new AuthorizationContextDataFactory())
                .CreateContextData<RelationshipsAuthorizationContextData>(this);

            return clone;
        }
    }
}