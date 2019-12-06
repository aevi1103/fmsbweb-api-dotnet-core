using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.Models.Safety.Incident;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Safety
{
    public class PropertyMappingService : IPropertyMappingService
    {
        private Dictionary<string, PropertyMappingValue> _incidentPropertyMapping =
            new Dictionary<string, PropertyMappingValue>(StringComparer.OrdinalIgnoreCase)
            {
                { "Id", new PropertyMappingValue(new List<string> { "Id" }) },
                { "Dept", new PropertyMappingValue(new List<string> { "Dept" }) },
                { "Name", new PropertyMappingValue(new List<string> { "Fname", "Lname" }) },
                { "Shift", new PropertyMappingValue(new List<string> { "Shift" }) },
                { "IncidentDate", new PropertyMappingValue(new List<string> { "AccidentDate" }) },
                { "Injury", new PropertyMappingValue(new List<string> { "Injury.InjuryName" }) },
                { "BodyPart", new PropertyMappingValue(new List<string> { "BodyPart.BodyPart1" }) },
                { "Supervisor", new PropertyMappingValue(new List<string> { "Supervisor" }) },
                { "InjuryStatus", new PropertyMappingValue(new List<string> { "InjuryStatId" }) },
                { "Description", new PropertyMappingValue(new List<string> { "Description" }) },
                { "InterimActionTaken", new PropertyMappingValue(new List<string> { "InterimActionTaken" }) },
                { "FinalCorrectiveAction", new PropertyMappingValue(new List<string> { "FinalCorrectiveAction" }) },
                { "ReasonSupportingOrirstat", new PropertyMappingValue(new List<string> { "ReasonSupportingOrirstat" }) },
                { "Modifieddate", new PropertyMappingValue(new List<string> { "Modifieddate" }) }
            };

        private IList<IPropertyMapping> _propertyMappings = new List<IPropertyMapping>();

        public PropertyMappingService()
        {
            //add _incidentPropertyMapping to _propertyMappings private prop
            _propertyMappings.Add(new PropertyMapping<IncidentDto, Incidence>(_incidentPropertyMapping));
        }

        public bool ValidMappingExistsFor<TSource, TDestination>(string fields)
        {
            var propertyMapping = GetPropertyMapping<TSource, TDestination>();

            if (string.IsNullOrWhiteSpace(fields))
            {
                return true;
            }

            // the string is separated by ",", so we split it.
            var fieldsAfterSplit = fields.Split(',');

            // run through the fields clauses
            foreach (var field in fieldsAfterSplit)
            {
                // trim
                var trimmedField = field.Trim();

                // remove everything after the first " " - if the fields 
                // are coming from an orderBy string, this part must be 
                // ignored
                var indexOfFirstSpace = trimmedField.IndexOf(" ");
                var propertyName = indexOfFirstSpace == -1 ?
                    trimmedField : trimmedField.Remove(indexOfFirstSpace);

                // find the matching property
                if (!propertyMapping.ContainsKey(propertyName))
                {
                    return false;
                }
            }
            return true;
        }

        public Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>()
        {
            //get matching mapping
            var matchingMapping = _propertyMappings.OfType<PropertyMapping<TSource, TDestination>>();

            if (matchingMapping.Count() == 1)
            {
                return matchingMapping.First()._mappingDictionary;
            }

            throw new Exception($"Cannot find exact property mapping instance for {typeof(TSource)},{typeof(TDestination)}");
        }
    }
}
