// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.FlowControl.V1
{

    /// <summary>
    /// ResourcePolicyRule is a predicate that matches some resource requests, testing the request's verb and the target resource. A ResourcePolicyRule matches a resource request if and only if: (a) at least one member of verbs matches the request, (b) at least one member of apiGroups matches the request, (c) at least one member of resources matches the request, and (d) either (d1) the request does not specify a namespace (i.e., `Namespace==""`) and clusterScope is true or (d2) the request specifies a namespace and least one member of namespaces matches the request's namespace.
    /// </summary>
    public class ResourcePolicyRuleArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiGroups", required: true)]
        private InputList<string>? _apiGroups;

        /// <summary>
        /// `apiGroups` is a list of matching API groups and may not be empty. "*" matches all API groups and, if present, must be the only entry. Required.
        /// </summary>
        public InputList<string> ApiGroups
        {
            get => _apiGroups ?? (_apiGroups = new InputList<string>());
            set => _apiGroups = value;
        }

        /// <summary>
        /// `clusterScope` indicates whether to match requests that do not specify a namespace (which happens either because the resource is not namespaced or the request targets all namespaces). If this field is omitted or false then the `namespaces` field must contain a non-empty list.
        /// </summary>
        [Input("clusterScope")]
        public Input<bool>? ClusterScope { get; set; }

        [Input("namespaces")]
        private InputList<string>? _namespaces;

        /// <summary>
        /// `namespaces` is a list of target namespaces that restricts matches.  A request that specifies a target namespace matches only if either (a) this list contains that target namespace or (b) this list contains "*".  Note that "*" matches any specified namespace but does not match a request that _does not specify_ a namespace (see the `clusterScope` field for that). This list may be empty, but only if `clusterScope` is true.
        /// </summary>
        public InputList<string> Namespaces
        {
            get => _namespaces ?? (_namespaces = new InputList<string>());
            set => _namespaces = value;
        }

        [Input("resources", required: true)]
        private InputList<string>? _resources;

        /// <summary>
        /// `resources` is a list of matching resources (i.e., lowercase and plural) with, if desired, subresource.  For example, [ "services", "nodes/status" ].  This list may not be empty. "*" matches all resources and, if present, must be the only entry. Required.
        /// </summary>
        public InputList<string> Resources
        {
            get => _resources ?? (_resources = new InputList<string>());
            set => _resources = value;
        }

        [Input("verbs", required: true)]
        private InputList<string>? _verbs;

        /// <summary>
        /// `verbs` is a list of matching verbs and may not be empty. "*" matches all verbs and, if present, must be the only entry. Required.
        /// </summary>
        public InputList<string> Verbs
        {
            get => _verbs ?? (_verbs = new InputList<string>());
            set => _verbs = value;
        }

        public ResourcePolicyRuleArgs()
        {
        }
        public static new ResourcePolicyRuleArgs Empty => new ResourcePolicyRuleArgs();
    }
}
