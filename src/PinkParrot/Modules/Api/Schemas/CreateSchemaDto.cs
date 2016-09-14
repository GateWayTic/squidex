﻿// ==========================================================================
//  CreateSchemaDto.cs
//  PinkParrot Headless CMS
// ==========================================================================
//  Copyright (c) PinkParrot Group
//  All rights reserved.
// ==========================================================================

using System.ComponentModel.DataAnnotations;
using PinkParrot.Core.Schemas;

namespace PinkParrot.Modules.Api.Schemas
{
    public class CreateSchemaDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public FieldProperties Properties { get; set; }
    }
}
