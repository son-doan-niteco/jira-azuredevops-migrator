﻿namespace Migration.WIContract
{
    public class WiField
    {
        public string ReferenceName { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return $"[{ReferenceName}]={Value}";
        }
    }

    public static class WiFieldReference
    {
        public static string ActivatedDate => "Microsoft.VSTS.Common.ActivatedDate";
        public static string ClosedDate => "Microsoft.VSTS.Common.ClosedDate";
        public static string ClosedBy => "Microsoft.VSTS.Common.ClosedBy";
        public static string AreaPath => "System.AreaPath";
        public static string IterationPath => "System.IterationPath";
        public static string State => "System.State";
        public static string CreatedBy => "System.CreatedBy";
        public static string ChangedBy => "System.ChangedBy";
        public static string AssignedTo => "System.AssignedTo";
        public static string ChangedDate => "System.ChangedDate";
        public static string CreatedDate => "System.CreatedDate";
        public static string ReproSteps => "Microsoft.VSTS.TCM.ReproSteps";
        public static string Description => "System.Description";
        public static string ActivatedBy => "Microsoft.VSTS.Common.ActivatedBy";
        public static string Tags => "System.Tags";

        // More fields mapping can be found here: https://docs.microsoft.com/en-us/azure/devops/reference/xml/reportable-fields-reference?view=azure-devops-2020
        public static string ResolvedBy => "Microsoft.VSTS.Common.ResolvedBy";
        public static string ResolvedDate => "Microsoft.VSTS.Common.ResolvedDate";

    }
}