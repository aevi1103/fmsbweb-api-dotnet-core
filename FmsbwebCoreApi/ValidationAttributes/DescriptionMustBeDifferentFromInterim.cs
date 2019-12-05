﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Models.Safety.Incident;

namespace FmsbwebCoreApi.ValidationAttributes
{
    public class DescriptionMustBeDifferentFromInterim : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var incident = (IncidentForManipulation)validationContext.ObjectInstance;

            if (incident.Description == incident.InterimActionTaken) //create a custom validation
            {
                return new ValidationResult(ErrorMessage,
                        new[] { nameof(IncidentForManipulation) }
                    );
            }

            return ValidationResult.Success;
        }
    }
}