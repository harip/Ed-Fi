﻿// ****************************************************************************
//  Copyright (C) 2014 Ed-Fi Alliance, LLC. All Rights Reserved.
// ****************************************************************************
namespace EdFi.Ods.Utilities.LoadGeneration.ValueBuilders
{
    public class EtagPropertySkipper : PropertySkipperBase
    {
        protected override string PropertyName
        {
            get { return "_etag"; }
        }
    }
}