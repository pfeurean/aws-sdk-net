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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.KinesisFirehose.Model;
using Amazon.KinesisFirehose.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisFirehose
{
    /// <summary>
    /// Implementation for accessing KinesisFirehose
    ///
    /// Amazon Kinesis Firehose API Reference 
    /// <para>
    /// Amazon Kinesis Firehose is a fully-managed service that delivers real-time streaming
    /// data to destinations such as Amazon S3 and Amazon Redshift.
    /// </para>
    /// </summary>
    public partial class AmazonKinesisFirehoseClient : AmazonServiceClient, IAmazonKinesisFirehose
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKinesisFirehoseClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisFirehoseConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisFirehoseClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisFirehoseConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(AmazonKinesisFirehoseConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisFirehoseClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisFirehoseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisFirehoseClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisFirehoseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Credentials and an
        /// AmazonKinesisFirehoseClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(AWSCredentials credentials, AmazonKinesisFirehoseConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisFirehoseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisFirehoseConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisFirehoseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisFirehoseConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisFirehoseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisFirehoseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisFirehoseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisFirehoseConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateDeliveryStream

        /// <summary>
        /// Creates a delivery stream.
        /// 
        ///  
        /// <para>
        /// <a>CreateDeliveryStream</a> is an asynchronous operation that immediately returns.
        /// The initial status of the delivery stream is <code>CREATING</code>. After the delivery
        /// stream is created, its status is <code>ACTIVE</code> and it now accepts data. Attempts
        /// to send data to a delivery stream that is not in the <code>ACTIVE</code> state cause
        /// an exception. To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// The name of a delivery stream identifies it. You can't have two delivery streams with
        /// the same name in the same region. Two delivery streams in different AWS accounts or
        /// different regions in the same AWS account can have the same name.
        /// </para>
        ///  
        /// <para>
        /// By default, you can create up to 5 delivery streams per region.
        /// </para>
        ///  
        /// <para>
        /// A delivery stream can only be configured with a single destination, Amazon S3 or Amazon
        /// Redshift. For correct <a>CreateDeliveryStream</a> request syntax, specify only one
        /// destination configuration parameter: either <code>RedshiftDestinationConfiguration</code>
        /// or <code>S3DestinationConfiguration</code>
        /// </para>
        ///  
        /// <para>
        /// As part of <code>S3DestinationConfiguration</code>, optional values <code>BufferingHints</code>,
        /// <code>EncryptionConfiguration</code>, and <code>CompressionFormat</code> can be provided.
        /// By default, if no <code>BufferingHints</code> value is provided, Amazon Kinesis Firehose
        /// buffers data up to 5 MB or for 5 minutes, whichever condition is satisfied first.
        /// Note that <code>BufferingHints</code> is a hint, so there are some cases where the
        /// service cannot adhere to these conditions strictly; for example, record boundaries
        /// are such that the size is a little over or under the configured buffering size. By
        /// default, no encryption is performed. We strongly recommend that you enable encryption
        /// to ensure secure data storage in Amazon S3.
        /// </para>
        ///  
        /// <para>
        /// A few notes about <code>RedshiftDestinationConfiguration</code>:
        /// </para>
        ///  <ul> <li>An Amazon Redshift destination requires an S3 bucket as intermediate location,
        /// as Amazon Kinesis Firehose first delivers data to S3 and then uses <code>COPY</code>
        /// syntax to load data into an Amazon Redshift table. This is specified in the <code>RedshiftDestinationConfiguration.S3Configuration</code>
        /// parameter element.</li> <li>The compression formats <code>SNAPPY</code> or <code>ZIP</code>
        /// cannot be specified in <code>RedshiftDestinationConfiguration.S3Configuration</code>
        /// because the Amazon Redshift <code>COPY</code> operation that reads from the S3 bucket
        /// doesn't support these compression formats.</li> <li>We strongly recommend that the
        /// username and password provided is used exclusively for Amazon Kinesis Firehose purposes,
        /// and that the permissions for the account are restricted for Amazon Redshift <code>INSERT</code>
        /// permissions.</li> </ul> 
        /// <para>
        /// Amazon Kinesis Firehose assumes the IAM role that is configured as part of destinations.
        /// The IAM role should allow the Amazon Kinesis Firehose principal to assume the role,
        /// and the role should have permissions that allows the service to deliver the data.
        /// For more information, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Amazon
        /// S3 Bucket Access</a> in the <i>Amazon Kinesis Firehose Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the CreateDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has an value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.LimitExceededException">
        /// You have already reached the limit for a requested resource.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        public CreateDeliveryStreamResponse CreateDeliveryStream(CreateDeliveryStreamRequest request)
        {
            var marshaller = new CreateDeliveryStreamRequestMarshaller();
            var unmarshaller = CreateDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<CreateDeliveryStreamRequest,CreateDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeliveryStream
        ///         operation.</returns>
        public IAsyncResult BeginCreateDeliveryStream(CreateDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDeliveryStreamRequestMarshaller();
            var unmarshaller = CreateDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeliveryStream.</param>
        /// 
        /// <returns>Returns a  CreateDeliveryStreamResult from KinesisFirehose.</returns>
        public  CreateDeliveryStreamResponse EndCreateDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeliveryStream

        /// <summary>
        /// Deletes a delivery stream and its data.
        /// 
        ///  
        /// <para>
        /// You can delete a delivery stream only if it is in <code>ACTIVE</code> or <code>DELETING</code>
        /// state, and not in the <code>CREATING</code> state. While the deletion request is in
        /// process, the delivery stream is in the <code>DELETING</code> state.
        /// </para>
        ///  
        /// <para>
        /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// While the delivery stream is <code>DELETING</code> state, the service may continue
        /// to accept the records, but the service doesn't make any guarantees with respect to
        /// delivering the data. Therefore, as a best practice, you should first stop any applications
        /// that are sending records before deleting a delivery stream.
        /// </para>
        /// </summary>
        /// <param name="deliveryStreamName">The name of the delivery stream.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        public DeleteDeliveryStreamResponse DeleteDeliveryStream(string deliveryStreamName)
        {
            var request = new DeleteDeliveryStreamRequest();
            request.DeliveryStreamName = deliveryStreamName;
            return DeleteDeliveryStream(request);
        }


        /// <summary>
        /// Deletes a delivery stream and its data.
        /// 
        ///  
        /// <para>
        /// You can delete a delivery stream only if it is in <code>ACTIVE</code> or <code>DELETING</code>
        /// state, and not in the <code>CREATING</code> state. While the deletion request is in
        /// process, the delivery stream is in the <code>DELETING</code> state.
        /// </para>
        ///  
        /// <para>
        /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// While the delivery stream is <code>DELETING</code> state, the service may continue
        /// to accept the records, but the service doesn't make any guarantees with respect to
        /// delivering the data. Therefore, as a best practice, you should first stop any applications
        /// that are sending records before deleting a delivery stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        public DeleteDeliveryStreamResponse DeleteDeliveryStream(DeleteDeliveryStreamRequest request)
        {
            var marshaller = new DeleteDeliveryStreamRequestMarshaller();
            var unmarshaller = DeleteDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryStreamRequest,DeleteDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeliveryStream
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDeliveryStream(DeleteDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDeliveryStreamRequestMarshaller();
            var unmarshaller = DeleteDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeliveryStream.</param>
        /// 
        /// <returns>Returns a  DeleteDeliveryStreamResult from KinesisFirehose.</returns>
        public  DeleteDeliveryStreamResponse EndDeleteDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDeliveryStream

        /// <summary>
        /// Describes the specified delivery stream and gets the status. For example, after your
        /// delivery stream is created, call <a>DescribeDeliveryStream</a> to see if the delivery
        /// stream is <code>ACTIVE</code> and therefore ready for data to be sent to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        public DescribeDeliveryStreamResponse DescribeDeliveryStream(DescribeDeliveryStreamRequest request)
        {
            var marshaller = new DescribeDeliveryStreamRequestMarshaller();
            var unmarshaller = DescribeDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryStreamRequest,DescribeDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveryStream
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDeliveryStream(DescribeDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDeliveryStreamRequestMarshaller();
            var unmarshaller = DescribeDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveryStream.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveryStreamResult from KinesisFirehose.</returns>
        public  DescribeDeliveryStreamResponse EndDescribeDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeliveryStreams

        /// <summary>
        /// Lists your delivery streams.
        /// 
        ///  
        /// <para>
        /// The number of delivery streams might be too large to return using a single call to
        /// <a>ListDeliveryStreams</a>. You can limit the number of delivery streams returned,
        /// using the <code>Limit</code> parameter. To determine whether there are more delivery
        /// streams to list, check the value of <code>HasMoreDeliveryStreams</code> in the output.
        /// If there are more delivery streams to list, you can request them by specifying the
        /// name of the last delivery stream returned in the call in the <code>ExclusiveStartDeliveryStreamName</code>
        /// parameter of a subsequent call.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListDeliveryStreams service method, as returned by KinesisFirehose.</returns>
        public ListDeliveryStreamsResponse ListDeliveryStreams()
        {
            return ListDeliveryStreams(new ListDeliveryStreamsRequest());
        }

        /// <summary>
        /// Lists your delivery streams.
        /// 
        ///  
        /// <para>
        /// The number of delivery streams might be too large to return using a single call to
        /// <a>ListDeliveryStreams</a>. You can limit the number of delivery streams returned,
        /// using the <code>Limit</code> parameter. To determine whether there are more delivery
        /// streams to list, check the value of <code>HasMoreDeliveryStreams</code> in the output.
        /// If there are more delivery streams to list, you can request them by specifying the
        /// name of the last delivery stream returned in the call in the <code>ExclusiveStartDeliveryStreamName</code>
        /// parameter of a subsequent call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliveryStreams service method.</param>
        /// 
        /// <returns>The response from the ListDeliveryStreams service method, as returned by KinesisFirehose.</returns>
        public ListDeliveryStreamsResponse ListDeliveryStreams(ListDeliveryStreamsRequest request)
        {
            var marshaller = new ListDeliveryStreamsRequestMarshaller();
            var unmarshaller = ListDeliveryStreamsResponseUnmarshaller.Instance;

            return Invoke<ListDeliveryStreamsRequest,ListDeliveryStreamsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeliveryStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeliveryStreams operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeliveryStreams
        ///         operation.</returns>
        public IAsyncResult BeginListDeliveryStreams(ListDeliveryStreamsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDeliveryStreamsRequestMarshaller();
            var unmarshaller = ListDeliveryStreamsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeliveryStreamsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeliveryStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeliveryStreams.</param>
        /// 
        /// <returns>Returns a  ListDeliveryStreamsResult from KinesisFirehose.</returns>
        public  ListDeliveryStreamsResponse EndListDeliveryStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeliveryStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecord

        /// <summary>
        /// Writes a single data record into an Amazon Kinesis Firehose delivery stream. To write
        /// multiple data records into a delivery stream, use <a>PutRecordBatch</a>. Applications
        /// using these operations are referred to as producers.
        /// 
        ///  
        /// <para>
        /// By default, each delivery stream can take in up to 2,000 transactions per second,
        /// 5,000 records per second, or 5 MB per second. Note that if you use <a>PutRecord</a>
        /// and <a>PutRecordBatch</a>, the limits are an aggregate across these two operations
        /// for each delivery stream. For more information about limits and how to request an
        /// increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data, for example, a segment from a log file, geographic location data, web
        /// site clickstream data, etc.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Firehose buffers records before delivering them to the destination.
        /// To disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application(s) to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Firehose does not maintain data record ordering. If the destination
        /// data needs to be re-ordered by the consumer application, the producer should include
        /// some form of sequence number in each data record. 
        /// </para>
        ///  
        /// <para>
        /// The <a>PutRecord</a> operation returns a <code>RecordId</code>, which is a unique
        /// string assigned to each record. Producer applications can use this ID for purposes
        /// such as auditability and investigation.
        /// </para>
        ///  
        /// <para>
        /// If the <a>PutRecord</a> operation throws a <code>ServiceUnavailableException</code>,
        /// back off and retry. If the exception persists, it is possible that the throughput
        /// limits have been exceeded for the delivery stream. 
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Amazon Kinesis Firehose are stored for 24 hours from the time
        /// they are added to a delivery stream as it attempts to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="deliveryStreamName">The name of the delivery stream.</param>
        /// <param name="record">The record.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has an value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>.
        /// </exception>
        public PutRecordResponse PutRecord(string deliveryStreamName, Record record)
        {
            var request = new PutRecordRequest();
            request.DeliveryStreamName = deliveryStreamName;
            request.Record = record;
            return PutRecord(request);
        }


        /// <summary>
        /// Writes a single data record into an Amazon Kinesis Firehose delivery stream. To write
        /// multiple data records into a delivery stream, use <a>PutRecordBatch</a>. Applications
        /// using these operations are referred to as producers.
        /// 
        ///  
        /// <para>
        /// By default, each delivery stream can take in up to 2,000 transactions per second,
        /// 5,000 records per second, or 5 MB per second. Note that if you use <a>PutRecord</a>
        /// and <a>PutRecordBatch</a>, the limits are an aggregate across these two operations
        /// for each delivery stream. For more information about limits and how to request an
        /// increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data, for example, a segment from a log file, geographic location data, web
        /// site clickstream data, etc.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Firehose buffers records before delivering them to the destination.
        /// To disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application(s) to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Firehose does not maintain data record ordering. If the destination
        /// data needs to be re-ordered by the consumer application, the producer should include
        /// some form of sequence number in each data record. 
        /// </para>
        ///  
        /// <para>
        /// The <a>PutRecord</a> operation returns a <code>RecordId</code>, which is a unique
        /// string assigned to each record. Producer applications can use this ID for purposes
        /// such as auditability and investigation.
        /// </para>
        ///  
        /// <para>
        /// If the <a>PutRecord</a> operation throws a <code>ServiceUnavailableException</code>,
        /// back off and retry. If the exception persists, it is possible that the throughput
        /// limits have been exceeded for the delivery stream. 
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Amazon Kinesis Firehose are stored for 24 hours from the time
        /// they are added to a delivery stream as it attempts to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has an value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>.
        /// </exception>
        public PutRecordResponse PutRecord(PutRecordRequest request)
        {
            var marshaller = new PutRecordRequestMarshaller();
            var unmarshaller = PutRecordResponseUnmarshaller.Instance;

            return Invoke<PutRecordRequest,PutRecordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecord
        ///         operation.</returns>
        public IAsyncResult BeginPutRecord(PutRecordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutRecordRequestMarshaller();
            var unmarshaller = PutRecordResponseUnmarshaller.Instance;

            return BeginInvoke<PutRecordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecord.</param>
        /// 
        /// <returns>Returns a  PutRecordResult from KinesisFirehose.</returns>
        public  PutRecordResponse EndPutRecord(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecordBatch

        /// <summary>
        /// Writes multiple data records into a delivery stream in a single call, which can achieve
        /// higher throughput per producer than when writing single records. To write single data
        /// records into a delivery stream, use <a>PutRecord</a>. Applications using these operations
        /// are referred to as producers.
        /// 
        ///  
        /// <para>
        /// Each <a>PutRecordBatch</a> request supports up to 500 records. Each record in the
        /// request can be as large as 1,000 KB (before 64-bit encoding), up to a limit of 4 MB
        /// for the entire request. By default, each delivery stream can take in up to 2,000 transactions
        /// per second, 5,000 records per second, or 5 MB per second. Note that if you use <a>PutRecord</a>
        /// and <a>PutRecordBatch</a>, the limits are an aggregate across these two operations
        /// for each delivery stream. For more information about limits and how to request an
        /// increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data, for example, a segment from a log file, geographic location data, web
        /// site clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Firehose buffers records before delivering them to the destination.
        /// To disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application(s) to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// The <a>PutRecordBatch</a> response includes a count of any failed records, <code>FailedPutCount</code>,
        /// and an array of responses, <code>RequestResponses</code>. The <code>FailedPutCount</code>
        /// value is a count of records that failed. Each entry in the <code>RequestResponses</code>
        /// array gives additional information of the processed record. Each entry in <code>RequestResponses</code>
        /// directly correlates with a record in the request array using the same ordering, from
        /// the top to the bottom of the request and response. <code>RequestResponses</code> always
        /// includes the same number of records as the request array. <code>RequestResponses</code>
        /// both successfully and unsuccessfully processed records. Amazon Kinesis Firehose attempts
        /// to process all records in each <a>PutRecordBatch</a> request. A single record failure
        /// does not stop the processing of subsequent records.
        /// </para>
        ///  
        /// <para>
        /// A successfully processed record includes a <code>RecordId</code> value, which is a
        /// unique value identified for the record. An unsuccessfully processed record includes
        /// <code>ErrorCode</code> and <code>ErrorMessage</code> values. <code>ErrorCode</code>
        /// reflects the type of error and is one of the following values: <code>ServiceUnavailable</code>
        /// or <code>InternalFailure</code>. <code>ErrorMessage</code> provides more detailed
        /// information about the error.
        /// </para>
        ///  
        /// <para>
        /// If <code>FailedPutCount</code> is greater than 0 (zero), retry the request. A retry
        /// of the entire batch of records is possible; however, we strongly recommend that you
        /// inspect the entire response and resend only those records that failed processing.
        /// This minimizes duplicate records and also reduces the total bytes sent (and corresponding
        /// charges).
        /// </para>
        ///  
        /// <para>
        /// If the <a>PutRecordBatch</a> operation throws a <code>ServiceUnavailableException</code>,
        /// back off and retry. If the exception persists, it is possible that the throughput
        /// limits have been exceeded for the delivery stream.
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Amazon Kinesis Firehose are stored for 24 hours from the time
        /// they are added to a delivery stream as it attempts to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="deliveryStreamName">The name of the delivery stream.</param>
        /// <param name="records">One or more records.</param>
        /// 
        /// <returns>The response from the PutRecordBatch service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has an value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>.
        /// </exception>
        public PutRecordBatchResponse PutRecordBatch(string deliveryStreamName, List<Record> records)
        {
            var request = new PutRecordBatchRequest();
            request.DeliveryStreamName = deliveryStreamName;
            request.Records = records;
            return PutRecordBatch(request);
        }


        /// <summary>
        /// Writes multiple data records into a delivery stream in a single call, which can achieve
        /// higher throughput per producer than when writing single records. To write single data
        /// records into a delivery stream, use <a>PutRecord</a>. Applications using these operations
        /// are referred to as producers.
        /// 
        ///  
        /// <para>
        /// Each <a>PutRecordBatch</a> request supports up to 500 records. Each record in the
        /// request can be as large as 1,000 KB (before 64-bit encoding), up to a limit of 4 MB
        /// for the entire request. By default, each delivery stream can take in up to 2,000 transactions
        /// per second, 5,000 records per second, or 5 MB per second. Note that if you use <a>PutRecord</a>
        /// and <a>PutRecordBatch</a>, the limits are an aggregate across these two operations
        /// for each delivery stream. For more information about limits and how to request an
        /// increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data, for example, a segment from a log file, geographic location data, web
        /// site clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Firehose buffers records before delivering them to the destination.
        /// To disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application(s) to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// The <a>PutRecordBatch</a> response includes a count of any failed records, <code>FailedPutCount</code>,
        /// and an array of responses, <code>RequestResponses</code>. The <code>FailedPutCount</code>
        /// value is a count of records that failed. Each entry in the <code>RequestResponses</code>
        /// array gives additional information of the processed record. Each entry in <code>RequestResponses</code>
        /// directly correlates with a record in the request array using the same ordering, from
        /// the top to the bottom of the request and response. <code>RequestResponses</code> always
        /// includes the same number of records as the request array. <code>RequestResponses</code>
        /// both successfully and unsuccessfully processed records. Amazon Kinesis Firehose attempts
        /// to process all records in each <a>PutRecordBatch</a> request. A single record failure
        /// does not stop the processing of subsequent records.
        /// </para>
        ///  
        /// <para>
        /// A successfully processed record includes a <code>RecordId</code> value, which is a
        /// unique value identified for the record. An unsuccessfully processed record includes
        /// <code>ErrorCode</code> and <code>ErrorMessage</code> values. <code>ErrorCode</code>
        /// reflects the type of error and is one of the following values: <code>ServiceUnavailable</code>
        /// or <code>InternalFailure</code>. <code>ErrorMessage</code> provides more detailed
        /// information about the error.
        /// </para>
        ///  
        /// <para>
        /// If <code>FailedPutCount</code> is greater than 0 (zero), retry the request. A retry
        /// of the entire batch of records is possible; however, we strongly recommend that you
        /// inspect the entire response and resend only those records that failed processing.
        /// This minimizes duplicate records and also reduces the total bytes sent (and corresponding
        /// charges).
        /// </para>
        ///  
        /// <para>
        /// If the <a>PutRecordBatch</a> operation throws a <code>ServiceUnavailableException</code>,
        /// back off and retry. If the exception persists, it is possible that the throughput
        /// limits have been exceeded for the delivery stream.
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Amazon Kinesis Firehose are stored for 24 hours from the time
        /// they are added to a delivery stream as it attempts to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecordBatch service method.</param>
        /// 
        /// <returns>The response from the PutRecordBatch service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has an value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Firehose Limits</a>.
        /// </exception>
        public PutRecordBatchResponse PutRecordBatch(PutRecordBatchRequest request)
        {
            var marshaller = new PutRecordBatchRequestMarshaller();
            var unmarshaller = PutRecordBatchResponseUnmarshaller.Instance;

            return Invoke<PutRecordBatchRequest,PutRecordBatchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecordBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecordBatch operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecordBatch
        ///         operation.</returns>
        public IAsyncResult BeginPutRecordBatch(PutRecordBatchRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutRecordBatchRequestMarshaller();
            var unmarshaller = PutRecordBatchResponseUnmarshaller.Instance;

            return BeginInvoke<PutRecordBatchRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecordBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecordBatch.</param>
        /// 
        /// <returns>Returns a  PutRecordBatchResult from KinesisFirehose.</returns>
        public  PutRecordBatchResponse EndPutRecordBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDestination

        /// <summary>
        /// Updates the specified destination of the specified delivery stream. 
        /// 
        ///  
        /// <para>
        /// This operation can be used to change the destination type (for example, to replace
        /// the Amazon S3 destination with Amazon Redshift) or change the parameters associated
        /// with a given destination (for example, to change the bucket name of the Amazon S3
        /// destination). The update may not occur immediately. The target delivery stream remains
        /// active while the configurations are updated, so data writes to the delivery stream
        /// can continue during this process. The updated configurations are normally effective
        /// within a few minutes. 
        /// </para>
        ///  
        /// <para>
        /// If the destination type is the same, Amazon Kinesis Firehose merges the configuration
        /// parameters specified in the <a>UpdateDestination</a> request with the destination
        /// configuration that already exists on the delivery stream. If any of the parameters
        /// are not specified in the update request, then the existing configuration parameters
        /// are retained. For example, in the Amazon S3 destination, if <a>EncryptionConfiguration</a>
        /// is not specified then the existing <a>EncryptionConfiguration</a> is maintained on
        /// the destination.
        /// </para>
        ///  
        /// <para>
        /// If the destination type is not the same, for example, changing the destination from
        /// Amazon S3 to Amazon Redshift, Amazon Kinesis Firehose does not merge any parameters.
        /// In this case, all parameters must be specified.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Firehose uses the <code>CurrentDeliveryStreamVersionId</code> to avoid
        /// race conditions and conflicting merges. This is a required field in every request
        /// and the service only updates the configuration if the existing configuration matches
        /// the <code>VersionId</code>. After the update is applied successfully, the <code>VersionId</code>
        /// is updated, which can be retrieved with the <a>DescribeDeliveryStream</a> operation.
        /// The new <code>VersionId</code> should be uses to set <code>CurrentDeliveryStreamVersionId</code>
        /// in the next <a>UpdateDestination</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ConcurrentModificationException">
        /// Another modification has already happened. Fetch <code>VersionId</code> again and
        /// use it to update the destination.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has an value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        public UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            var marshaller = new UpdateDestinationRequestMarshaller();
            var unmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationRequest,UpdateDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        public IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDestinationRequestMarshaller();
            var unmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDestinationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from KinesisFirehose.</returns>
        public  UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDestinationResponse>(asyncResult);
        }

        #endregion
        
    }
}