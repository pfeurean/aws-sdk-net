/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Redshift.Model;

namespace Amazon.Redshift
{
    /// <summary>
    /// Interface for accessing Redshift
    ///
    /// Amazon Redshift 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is an interface reference for Amazon Redshift. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Redshift
    /// clusters. Note that Amazon Redshift is asynchronous, which means that some interfaces
    /// may require techniques, such as polling or asynchronous callback handlers, to determine
    /// when a command has been applied. In this reference, the parameter descriptions indicate
    /// whether a change is applied immediately, on the next instance reboot, or during the
    /// next maintenance window. For a summary of the Amazon Redshift cluster management interfaces,
    /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon Redshift manages all the work of setting up, operating, and scaling a data
    /// warehouse: provisioning capacity, monitoring and backing up the cluster, and applying
    /// patches and upgrades to the Amazon Redshift engine. You can focus on using your data
    /// to acquire new insights for your business and customers.
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a> explains how to design, build, query, and maintain
    /// the databases that make up your data warehouse. 
    /// </para>
    /// </summary>
    public partial interface IAmazonRedshift : IAmazonService, IDisposable
    {
                
        #region  AcceptReservedNodeExchange


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptReservedNodeExchange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedNodeExchange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        Task<AcceptReservedNodeExchangeResponse> AcceptReservedNodeExchangeAsync(AcceptReservedNodeExchangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeClusterSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeSnapshotAccess


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteClusterSnapshots


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        Task<BatchDeleteClusterSnapshotsResponse> BatchDeleteClusterSnapshotsAsync(BatchDeleteClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchModifyClusterSnapshots


        /// <summary>
        /// Initiates the asynchronous execution of the BatchModifyClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchModifyClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        Task<BatchModifyClusterSnapshotsResponse> BatchModifyClusterSnapshotsAsync(BatchModifyClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelResize


        /// <summary>
        /// Initiates the asynchronous execution of the CancelResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        Task<CancelResizeResponse> CancelResizeAsync(CancelResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCluster


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClusterSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClusterSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHsmClientCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHsmConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshotCopyGrant


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        Task<CreateSnapshotCopyGrantResponse> CreateSnapshotCopyGrantAsync(CreateSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshotSchedule


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        Task<CreateSnapshotScheduleResponse> CreateSnapshotScheduleAsync(CreateSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTags


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCluster


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClusterSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClusterSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHsmClientCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHsmConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSnapshotCopyGrant


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        Task<DeleteSnapshotCopyGrantResponse> DeleteSnapshotCopyGrantAsync(DeleteSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSnapshotSchedule


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterDbRevisions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterDbRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterDbRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        Task<DescribeClusterDbRevisionsResponse> DescribeClusterDbRevisionsAsync(DescribeClusterDbRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterParameterGroups


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusters


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        Task<DescribeClustersResponse> DescribeClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterSecurityGroups


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterSnapshots


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterSubnetGroups


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterTracks


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterTracks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterTracks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        Task<DescribeClusterTracksResponse> DescribeClusterTracksAsync(DescribeClusterTracksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterVersions


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDefaultClusterParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEventCategories


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEventSubscriptions


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHsmClientCertificates


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHsmConfigurations


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoggingStatus


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrderableClusterOptions


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS Region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedNodeOfferings


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedNodes


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeResize


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshotCopyGrants


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotCopyGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        Task<DescribeSnapshotCopyGrantsResponse> DescribeSnapshotCopyGrantsAsync(DescribeSnapshotCopyGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshotSchedules


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        Task<DescribeSnapshotSchedulesResponse> DescribeSnapshotSchedulesAsync(DescribeSnapshotSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStorage


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        Task<DescribeStorageResponse> DescribeStorageAsync(DescribeStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTableRestoreStatus


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        Task<DescribeTableRestoreStatusResponse> DescribeTableRestoreStatusAsync(DescribeTableRestoreStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableLogging


        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableSnapshotCopy


        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableLogging


        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableSnapshotCopy


        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetClusterCredentials


        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        Task<GetClusterCredentialsResponse> GetClusterCredentialsAsync(GetClusterCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReservedNodeExchangeOfferings


        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedNodeExchangeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        Task<GetReservedNodeExchangeOfferingsResponse> GetReservedNodeExchangeOfferingsAsync(GetReservedNodeExchangeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyCluster


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClusterDbRevision


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterDbRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterDbRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        Task<ModifyClusterDbRevisionResponse> ModifyClusterDbRevisionAsync(ModifyClusterDbRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClusterIamRoles


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterIamRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterIamRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        Task<ModifyClusterIamRolesResponse> ModifyClusterIamRolesAsync(ModifyClusterIamRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClusterMaintenance


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterMaintenance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterMaintenance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        Task<ModifyClusterMaintenanceResponse> ModifyClusterMaintenanceAsync(ModifyClusterMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        Task<ModifyClusterSnapshotResponse> ModifyClusterSnapshotAsync(ModifyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClusterSnapshotSchedule


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        Task<ModifyClusterSnapshotScheduleResponse> ModifyClusterSnapshotScheduleAsync(ModifyClusterSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClusterSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySnapshotCopyRetentionPeriod


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySnapshotSchedule


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        Task<ModifySnapshotScheduleResponse> ModifySnapshotScheduleAsync(ModifySnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseReservedNodeOffering


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootCluster


        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResizeCluster


        /// <summary>
        /// Initiates the asynchronous execution of the ResizeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResizeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        Task<ResizeClusterResponse> ResizeClusterAsync(ResizeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreFromClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreTableFromClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTableFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        Task<RestoreTableFromClusterSnapshotResponse> RestoreTableFromClusterSnapshotAsync(RestoreTableFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeClusterSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSnapshotAccess


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RotateEncryptionKey


        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}