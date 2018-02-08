// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using WebKit;

namespace MASFoundation
{
    // typedef void (^MASCompletionErrorBlock)(BOOL, NSError * _Nullable);
    /// <summary>
    /// A standard (bool arg0, NSError arg1) block.
    /// </summary>
    delegate void MASCompletionErrorBlock(bool arg0, [NullAllowed] NSError arg1);

    // typedef void (^MASObjectResponseErrorBlock)(id _Nullable, NSError * _Nullable);
    /// <summary>
    /// A standard (var arg0, NSError arg1) block.  The response object could potentially be any type of MASObject.
    /// </summary>
    delegate void MASObjectResponseErrorBlock([NullAllowed] NSObject arg0, [NullAllowed] NSError arg1);

    // typedef void (^MASObjectsResponseErrorBlock)(NSArray<id> * _Nullable, NSError * _Nullable);
    /// <summary>
    /// A standard (NSArray arg0, NSError arg1) block.  The response objects could potentially be any type of MASObject.
    /// </summary>
    delegate void MASObjectsResponseErrorBlock([NullAllowed] NSObject[] arg0, [NullAllowed] NSError arg1);

    // typedef void (^MASResponseInfoErrorBlock)(NSDictionary<NSString *,id> * _Nullable, NSError * _Nullable);
    /// <summary>
    /// A standard (NSDictionary arg0, NSError arg1) block.  The response object could potentially be any type of object.  It is most often used to return NSString JSON responses from HTTP calls for example.
    /// </summary>
    delegate void MASResponseInfoErrorBlock([NullAllowed] NSDictionary<NSString, NSObject> arg0, [NullAllowed] NSError arg1);

    // typedef void (^MASUserResponseErrorBlock)(MASUser * _Nullable, NSError * _Nullable);
    /// <summary>
    /// The MASUser specific (MASUser arg0, NSError arg1) block.
    /// </summary>
    delegate void MASUserResponseErrorBlock([NullAllowed] MASUser arg0, [NullAllowed] NSError arg1);

    // typedef void (^MASAuthCredentialsBlock)(MASAuthCredentials * _Nullable, BOOL, MASCompletionErrorBlock _Nullable);
    /// <summary>
    /// The MASAuthCredentialsBlcok to provide auth credentials for device registration and/or user authentication.
    /// </summary>
    delegate void MASAuthCredentialsBlock([NullAllowed] MASAuthCredentials arg0, bool arg1, [BlockCallback, NullAllowed] MASCompletionErrorBlock arg2);

    // typedef void (^MASUserAuthCredentialsBlock)(MASAuthCredentialsBlock _Nonnull);
    /// <summary>
    /// The user auth credentials blcok that will be invoked by SDK to notify developers to provide auth credentials.
    /// </summary>
    delegate void MASUserAuthCredentialsBlock([BlockCallback] MASAuthCredentialsBlock arg0);

    //// typedef void (^MASOTPGenerationBlock)(NSArray * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASOTPGenerationBlock(NSObject[] arg0, bool arg1, [BlockCallback, NullAllowed] MASCompletionErrorBlock arg2);

    //// typedef void (^MASOTPFetchCredentialsBlock)(NSString * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASOTPFetchCredentialsBlock(string arg0, bool arg1, [BlockCallback, NullAllowed] MASCompletionErrorBlock arg2);

    //// typedef void (^MASOTPChannelSelectionBlock)(NSArray * _Nonnull, MASOTPGenerationBlock _Nonnull);
    //delegate void MASOTPChannelSelectionBlock(NSObject[] arg0, [BlockCallback] MASOTPGenerationBlock arg1);

    //// typedef void (^MASOTPCredentialsBlock)(MASOTPFetchCredentialsBlock _Nonnull, NSError * _Nullable);
    //delegate void MASOTPCredentialsBlock([BlockCallback] MASOTPFetchCredentialsBlock arg0, [NullAllowed] NSError arg1);

    //// typedef void (^MASBiometricModalitiesBlock)(NSArray * _Nullable, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASBiometricModalitiesBlock([NullAllowed] NSObject[] arg0, bool arg1, [NullAllowed] MASCompletionErrorBlock arg2);

    //// typedef void (^MASBiometricRegistrationModalitiesSelectionBlock)(NSArray * _Nonnull, MASBiometricModalitiesBlock _Nonnull);
    //delegate void MASBiometricRegistrationModalitiesSelectionBlock(NSObject[] arg0, MASBiometricModalitiesBlock arg1);

    //// typedef void (^MASBiometricDeregistrationModalitiesSelectionBlock)(NSArray * _Nonnull, MASBiometricModalitiesBlock _Nonnull);
    //delegate void MASBiometricDeregistrationModalitiesSelectionBlock(NSObject[] arg0, MASBiometricModalitiesBlock arg1);

    // typedef void (^MASGatewayMonitorStatusBlock)(MASGatewayMonitoringStatus);
    /// <summary>
    /// MThe Gateway monitor status block that will receive a MASGatewayMonitoringStatus update when a new status value change is triggered.
    /// </summary>
    /// <code>
    /// MASGatewayMonitoringStatus.ewayMonitoringStatusNotReachable
    /// MASGatewayMonitoringStatus.ewayMonitoringStatusReachableViaWWAN
    /// MASGatewayMonitoringStatus.ewayMonitoringStatusReachableViaWiFi
    /// </code>
    delegate void MASGatewayMonitorStatusBlock(MASGatewayMonitoringStatus arg0);

    //// typedef void (^MASBasicCredentialsBlock)(NSString * _Nonnull, NSString * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASBasicCredentialsBlock(string arg0, string arg1, bool arg2, [BlockCallback, NullAllowed] MASCompletionErrorBlock arg3);

    //// typedef void (^MASAuthorizationCodeCredentialsBlock)(NSString * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASAuthorizationCodeCredentialsBlock(string arg0, bool arg1, [BlockCallback, NullAllowed] MASCompletionErrorBlock arg2);

    //// typedef void (^MASUserLoginWithUserCredentialsBlock)(MASBasicCredentialsBlock _Nonnull, MASAuthorizationCodeCredentialsBlock _Nonnull);
    //delegate void MASUserLoginWithUserCredentialsBlock([BlockCallback] MASBasicCredentialsBlock arg0, [BlockCallback] MASAuthorizationCodeCredentialsBlock arg1);

    // @interface MASObject : NSObject <NSCopying, NSCoding>
    /// <summary>
    /// The `MASObject` class is a local representation of data persisted to the MAS cloud. This is the main class that is used to interact with objects in your app.
    /// </summary>
    [BaseType(typeof(NSObject))]
    interface MASObject : INSCopying, INSCoding
    {
        // -(instancetype _Nullable)initWithAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes;
        /// <summary>
        /// Init the object with passed attributes in a form of NSDictionary
        /// </summary>
        /// <returns>The instance of the MASObject object</returns>
        /// <param name="attributes">NSDictionary to be used as attributes</param>
        [Export("initWithAttributes:")]
        IntPtr Constructor(NSDictionary<NSString, NSString> attributes);

        // +(instancetype _Nullable)objectWithClassName:(NSString * _Nonnull)className;
        /// <summary>
        /// Creates a new MASObject with a class name
        /// </summary>
        /// <returns>MASObject that is instantiated with the given class name.</returns>
        /// <param name="className">A class name can be any alphanumeric string that begins with a letter. It represents an object in your app, like a 'User' or a 'Document'.</param>
        [Static]
        [Export("objectWithClassName:")]
        [return: NullAllowed]
        MASObject ObjectWithClassName(string className);

        // +(instancetype _Nullable)objectWithClassName:(NSString * _Nonnull)className withData:(NSDictionary<NSString *,NSString *> * _Nonnull)dictionary;
        /// <summary>
        /// Creates a new MASObject with a class name and a dictionary as the data
        /// </summary>
        /// <returns>MASObject that is instantiated with the given class name and dictionary.</returns>
        /// <param name="className">A class name can be any alphanumeric string that begins with a letter. It represents an object in your app, like a 'User' or a 'Document'.</param>
        /// <param name="dictionary">A disctionary that will be used as a data.</param>
        [Static]
        [Export("objectWithClassName:withData:")]
        [return: NullAllowed]
        MASObject ObjectWithClassName(string className, NSDictionary<NSString, NSString> dictionary);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull className;
        /// <summary>
        /// The class name of the object.
        /// </summary>
        /// <value>The name of the class.</value>
        [Export("className")]
        string ClassName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull objectId;
        /// <summary>
        /// The id of the object.
        /// </summary>
        /// <value>The object identifier.</value>
        [Export("objectId")]
        string ObjectId { get; }

        // @property (readonly, copy, nonatomic) NSMutableDictionary<NSString *,NSString *> * _Nonnull _attributes;
        /// <summary>
        /// List of attributes of the object.
        /// </summary>
        /// <value>The attributes.</value>
        [Export("_attributes", ArgumentSemantic.Copy)]
        NSMutableDictionary<NSString, NSString> _attributes { get; }

        // -(id _Nullable)objectForKey:(id _Nonnull)key;
        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key.</returns>
        /// <param name="key">The given identifying key for which to return the corresponding value.</param>
        [Export("objectForKey:")]
        [return: NullAllowed]
        NSObject ObjectForKey(NSObject key);

        // -(void)setObject:(id _Nonnull)object forKey:(id<NSCopying> _Nonnull)key;
        /// <summary>
        /// Sets the object associated with a given key.
        /// </summary>
        /// <param name="object">The object for `key`. A strong reference to the object is maintaned by MASObject. Raises an `NSInvalidArgumentException` if `object` is `null`. If you need to represent a `null` value - use `NSNull`.</param>
        /// <param name="key">The key for `object`. Raises an `NSInvalidArgumentException` if `key` is `null`.</param>
        [Export("setObject:forKey:")]
        void SetObjectForKey(NSObject @object, NSCopying key);

        // -(id _Nullable)objectForKeyedSubscript:(id _Nonnull)key;
        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key.</returns>
        /// <param name="key">The key for which to return the corresponding value.</param>
        [Export("objectForKeyedSubscript:")]
        [return: NullAllowed]
        NSObject ObjectForKeyedSubscript(NSObject key);

        // -(void)setObject:(id _Nonnull)object forKeyedSubscript:(id<NSCopying> _Nonnull)key;
        /// <summary>
        /// Returns the value associated with a given key.
        /// @discussion This method enables usage of literal syntax on `MASObject`. E.g. `object["key"] = "value";`
        /// </summary>
        /// <param name="object">The object for `key`. A strong reference to the object is maintaned by PFObject. Raises an `NSInvalidArgumentException` if `object` is `null`. If you need to represent a `null` value - use `NSNull`.</param>
        /// <param name="key">The key for `object`. Raises an `NSInvalidArgumentException` if `key` is `null`.</param>
        [Export("setObject:forKeyedSubscript:")]
        void SetObjectForKeyedSubscript(NSObject @object, NSCopying key);

        // -(void)listAttributes;
        /// <summary>
        /// List all attributes from the Object
        /// </summary>
        [Export("listAttributes")]
        void ListAttributes();
    }

    [Static]
    // [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern double MASFoundationVersionNumber;
        [Field("MASFoundationVersionNumber", "__Internal")]
        double MASFoundationVersionNumber { get; }

        // extern const unsigned char [] MASFoundationVersionString;
        [Field("MASFoundationVersionString", "__Internal")]
        //byte[] MASFoundationVersionString { get; }
        IntPtr MASFoundationVersionString { get; }
    }

    // @protocol MASProximityLoginDelegate <NSObject>
    //[Protocol, Model]
    [BaseType(typeof(NSObject))]
    [Model]
    interface MASProximityLoginDelegate
    {
        // @required -(void)handleBLEProximityLoginUserConsent:(MASCompletionErrorBlock _Nullable)completion deviceName:(NSString * _Nonnull)deviceName;
        [Abstract]
        [Export("handleBLEProximityLoginUserConsent:deviceName:")]
        void HandleBLEProximityLoginUserConsent([NullAllowed] MASCompletionErrorBlock completion, string deviceName);

        // @optional -(void)didReceiveAuthorizationCode:(NSString * _Nonnull)authorizationCode;
        [Export("didReceiveAuthorizationCode:")]
        void DidReceiveAuthorizationCode(string authorizationCode);

        // @optional -(void)didReceiveBLEProximityLoginStateUpdate:(MASBLEServiceState)state;
        [Export("didReceiveBLEProximityLoginStateUpdate:")]
        void DidReceiveBLEProximityLoginStateUpdate(MASBLEServiceState state);

        // @optional -(void)didReceiveProximityLoginError:(NSError * _Nonnull)error;
        [Export("didReceiveProximityLoginError:")]
        void DidReceiveProximityLoginError(NSError error);
    }

    // @interface MASService : NSObject
    [BaseType(typeof(NSObject))]
    interface MASService
    {
        // @property (readonly, assign, nonatomic) MASServiceLifecycleStatus lifecycleStatus;
        [Export("lifecycleStatus", ArgumentSemantic.Assign)]
        MASServiceLifecycleStatus LifecycleStatus { get; }

        // +(instancetype _Nullable)sharedService;
        [Static]
        [Export("sharedService")]
        [return: NullAllowed]
        MASService SharedService();

        // +(NSString * _Nullable)serviceUUID;
        [Static]
        [NullAllowed, Export("serviceUUID")]
        //[Verify(MethodToProperty)]
        string ServiceUUID { get; }

        // -(void)serviceDidLoad;
        [Export("serviceDidLoad")]
        void ServiceDidLoad();

        // -(void)serviceWillStart;
        [Export("serviceWillStart")]
        void ServiceWillStart();

        // -(void)serviceDidStart;
        [Export("serviceDidStart")]
        void ServiceDidStart();

        // -(void)serviceWillStop;
        [Export("serviceWillStop")]
        void ServiceWillStop();

        // -(void)serviceDidStop;
        [Export("serviceDidStop")]
        void ServiceDidStop();

        // -(void)serviceDidReset;
        [Export("serviceDidReset")]
        void ServiceDidReset();

        // -(NSString * _Nonnull)lifecycleStatusAsString;
        [Export("lifecycleStatusAsString")]
        //[Verify(MethodToProperty)]
        string LifecycleStatusAsString { get; }

        // +(NSString * _Nonnull)lifecycleStatusToString:(MASServiceLifecycleStatus)status;
        [Static]
        [Export("lifecycleStatusToString:")]
        string LifecycleStatusToString(MASServiceLifecycleStatus status);
    }

    // @interface SubclassingHooks (MASService)
    [Category]
    [BaseType(typeof(MASService))]
    interface MASService_SubclassingHooks
    {
        // -(void)serviceDidFailWithError:(NSError * _Nullable)error;
        [Export("serviceDidFailWithError:")]
        void ServiceDidFailWithError([NullAllowed] NSError error);
    }

    // @interface MASSecurityConfiguration : MASObject
    [BaseType(typeof(MASObject))]
    interface MASSecurityConfiguration
    {
        // @property (assign) BOOL isPublic;
        [Export("isPublic")]
        bool IsPublic { get; set; }

        // @property (assign) BOOL validateDomainName;
        [Export("validateDomainName")]
        bool ValidateDomainName { get; set; }

        // @property (assign) BOOL trustPublicPKI;
        [Export("trustPublicPKI")]
        bool TrustPublicPKI { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable certificates;
        [NullAllowed, Export("certificates", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSArray[] Certificates { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable publicKeyHashes;
        [NullAllowed, Export("publicKeyHashes", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSArray[] PublicKeyHashes { get; set; }

        // @property (readonly, nonatomic, strong) NSURL * _Nonnull host;
        [Export("host", ArgumentSemantic.Strong)]
        NSUrl Host { get; }

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url __attribute__((objc_designated_initializer));
        [Export("initWithURL:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSUrl url);
    }

    // typedef void (^MQTTSubscriptionCompletionHandler)(NSArray * _Nonnull);
    delegate void MQTTSubscriptionCompletionHandler(NSObject[] arg0);

    // typedef void (^MQTTCompletionErrorBlock)(BOOL, NSError * _Nullable);
    delegate void MQTTCompletionErrorBlock(bool arg0, [NullAllowed] NSError arg1);

    // typedef void (^MQTTSubscriptionCompletionBlock)(BOOL, NSError * _Nullable, NSArray * _Nonnull);
    delegate void MQTTSubscriptionCompletionBlock(bool arg0, [NullAllowed] NSError arg1, NSObject[] arg2);

    // typedef void (^MQTTPublishingCompletionBlock)(BOOL, NSError * _Nullable, int);
    delegate void MQTTPublishingCompletionBlock(bool arg0, [NullAllowed] NSError arg1, int arg2);

    // typedef void (^MQTTMessageHandler)(MASMQTTMessage * _Nonnull);
    delegate void MQTTMessageHandler(MASMQTTMessage arg0);

    // typedef void (^MQTTDisconnectionHandler)(NSUInteger);
    delegate void MQTTDisconnectionHandler(nuint arg0);

    // @interface MASMQTTMessage : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface MASMQTTMessage : INSCoding
    {
        // @property (readonly, assign) unsigned short mid;
        [Export("mid")]
        ushort Mid { get; }

        // @property (readonly, copy) NSString * _Nonnull topic;
        [Export("topic")]
        string Topic { get; }

        // @property (readonly, copy) NSData * _Nonnull payload;
        [Export("payload", ArgumentSemantic.Copy)]
        NSData Payload { get; }

        // @property (readonly, assign) MQTTQualityOfService qos;
        [Export("qos", ArgumentSemantic.Assign)]
        MQTTQualityOfService Qos { get; }

        // @property (readonly, assign) BOOL retained;
        [Export("retained")]
        bool Retained { get; }

        // -(NSString * _Nonnull)payloadString;
        [Export("payloadString")]
        //[Verify(MethodToProperty)]
        string PayloadString { get; }

        // -(UIImage * _Nonnull)payloadImage;
        [Export("payloadImage")]
        //[Verify(MethodToProperty)]
        UIImage PayloadImage { get; }

        // -(id _Nonnull)initWithTopic:(NSString * _Nonnull)topic payload:(NSData * _Nonnull)payload qos:(MQTTQualityOfService)qos retain:(BOOL)retained mid:(short)mid;
        [Export("initWithTopic:payload:qos:retain:mid:")]
        IntPtr Constructor(string topic, NSData payload, MQTTQualityOfService qos, bool retained, short mid);
    }

    // @protocol MASConnectaMessagingClientDelegate <NSObject>
    //[Protocol, Model]
    [BaseType(typeof(NSObject))]
    [Model]
    interface MASConnectaMessagingClientDelegate
    {
        // @required -(void)onMessageReceived:(MASMQTTMessage * _Nonnull)message;
        [Abstract]
        [Export("onMessageReceived:")]
        void OnMessageReceived(MASMQTTMessage message);

        // @required -(void)onPublishMessage:(NSNumber * _Nonnull)messageId;
        [Abstract]
        [Export("onPublishMessage:")]
        void OnPublishMessage(NSNumber messageId);

        // @required -(void)onConnected:(MQTTConnectionReturnCode)rc;
        [Abstract]
        [Export("onConnected:")]
        void OnConnected(MQTTConnectionReturnCode rc);

        // @required -(void)onDisconnect:(MQTTConnectionReturnCode)rc;
        [Abstract]
        [Export("onDisconnect:")]
        void OnDisconnect(MQTTConnectionReturnCode rc);
    }

    // @interface MASMQTTClient : NSObject
    [BaseType(typeof(NSObject))]
    interface MASMQTTClient
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MASConnectaMessagingClientDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MASConnectaMessagingClientDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, assign, nonatomic) BOOL connected;
        [Export("connected")]
        bool Connected { get; }

        // @property (copy, nonatomic) MQTTMessageHandler _Nonnull messageHandler;
        [Export("messageHandler", ArgumentSemantic.Copy)]
        MQTTMessageHandler MessageHandler { get; set; }

        // @property (copy, nonatomic) MQTTDisconnectionHandler _Nonnull disconnectionHandler;
        [Export("disconnectionHandler", ArgumentSemantic.Copy)]
        MQTTDisconnectionHandler DisconnectionHandler { get; set; }

        // @property (assign, nonatomic) BOOL debugMode;
        [Export("debugMode")]
        bool DebugMode { get; set; }

        // @property (readwrite, copy) NSString * _Nonnull clientID;
        [Export("clientID")]
        string ClientID { get; set; }

        // +(instancetype _Nonnull)sharedClient;
        [Static]
        [Export("sharedClient")]
        MASMQTTClient SharedClient();

        // -(MASMQTTClient * _Nonnull)initWithClientId:(NSString * _Nonnull)clientId cleanSession:(BOOL)cleanSession;
        [Export("initWithClientId:cleanSession:")]
        IntPtr Constructor(string clientId, bool cleanSession);

        // -(void)setUsername:(NSString * _Nonnull)username Password:(NSString * _Nonnull)password;
        [Export("setUsername:Password:")]
        void SetUsername(string username, string password);

        // -(void)clearWill;
        [Export("clearWill")]
        void ClearWill();

        // -(void)setMessageRetry:(NSUInteger)seconds;
        [Export("setMessageRetry:")]
        void SetMessageRetry(nuint seconds);

        // -(void)setWill:(NSString * _Nonnull)payload toTopic:(NSString * _Nonnull)willTopic withQos:(MQTTQualityOfService)willQos retain:(BOOL)retain;
        [Export("setWill:toTopic:withQos:retain:")]
        void SetWill(string payload, string willTopic, MQTTQualityOfService willQos, bool retain);

        // +(NSString * _Nonnull)version;
        [Static]
        [Export("version")]
        //[Verify(MethodToProperty)]
        string Version { get; }

        // -(void)connectToHost:(NSString * _Nonnull)hostName completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
        [Export("connectToHost:completionHandler:")]
        void ConnectToHost(string hostName, Action<MQTTConnectionReturnCode> completionHandler);

        // -(void)connectToHost:(NSString * _Nonnull)hostName withTLS:(BOOL)tls completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
        [Export("connectToHost:withTLS:completionHandler:")]
        void ConnectToHost(string hostName, bool tls, Action<MQTTConnectionReturnCode> completionHandler);

        // -(void)connectWithHost:(NSString * _Nonnull)hostName withPort:(int)port enableTLS:(BOOL)tls completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
        [Export("connectWithHost:withPort:enableTLS:completionHandler:")]
        void ConnectWithHost(string hostName, int port, bool tls, Action<MQTTConnectionReturnCode> completionHandler);

        // -(void)connectWithHost:(NSString * _Nonnull)hostName withPort:(int)port enableTLS:(BOOL)tls usingSSLCACert:(NSString * _Nonnull)certFile completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
        [Export("connectWithHost:withPort:enableTLS:usingSSLCACert:completionHandler:")]
        void ConnectWithHost(string hostName, int port, bool tls, string certFile, Action<MQTTConnectionReturnCode> completionHandler);

        // -(void)disconnectWithCompletionHandler:(MQTTDisconnectionHandler _Nonnull)completionHandler;
        [Export("disconnectWithCompletionHandler:")]
        void DisconnectWithCompletionHandler(MQTTDisconnectionHandler completionHandler);

        // -(void)reconnect;
        [Export("reconnect")]
        void Reconnect();

        // -(void)publishString:(NSString * _Nonnull)payload toTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos retain:(BOOL)retain completionHandler:(void (^ _Nonnull)(int))completionHandler __attribute__((deprecated("Use the new publishString:toTopic:withQoS:retain:completion method instead.")));
        [Export("publishString:toTopic:withQos:retain:completionHandler:")]
        void PublishString(string payload, string topic, MQTTQualityOfService qos, bool retain, Action<int> completionHandler);

        // -(void)publishString:(NSString * _Nonnull)payload toTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos retain:(BOOL)retain completion:(MQTTPublishingCompletionBlock _Nullable)completion;
        [Export("publishString:toTopic:withQos:retain:completion:")]
        void PublishString(string payload, string topic, MQTTQualityOfService qos, bool retain, [NullAllowed] MQTTPublishingCompletionBlock completion);

        // -(void)subscribeToTopic:(NSString * _Nonnull)topic withCompletionHandler:(MQTTSubscriptionCompletionHandler _Nonnull)completionHandler __attribute__((deprecated("Use the new subscribeToTopic:withCompletion method instead.")));
        [Export("subscribeToTopic:withCompletionHandler:")]
        void SubscribeToTopic(string topic, MQTTSubscriptionCompletionHandler completionHandler);

        // -(void)subscribeToTopic:(NSString * _Nonnull)topic withCompletion:(MQTTSubscriptionCompletionBlock _Nullable)completion;
        [Export("subscribeToTopic:withCompletion:")]
        void SubscribeToTopic(string topic, [NullAllowed] MQTTSubscriptionCompletionBlock completion);

        // -(void)subscribeToTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos completionHandler:(MQTTSubscriptionCompletionHandler _Nonnull)completionHandler __attribute__((deprecated("Use the new subscribeToTopic:withQos:completion method instead.")));
        [Export("subscribeToTopic:withQos:completionHandler:")]
        void SubscribeToTopic(string topic, MQTTQualityOfService qos, MQTTSubscriptionCompletionHandler completionHandler);

        // -(void)subscribeToTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos completion:(MQTTSubscriptionCompletionBlock _Nullable)completion;
        [Export("subscribeToTopic:withQos:completion:")]
        void SubscribeToTopic(string topic, MQTTQualityOfService qos, [NullAllowed] MQTTSubscriptionCompletionBlock completion);

        // -(void)unsubscribeFromTopic:(NSString * _Nonnull)topic withCompletionHandler:(MQTTCompletionErrorBlock _Nullable)completionHandler;
        [Export("unsubscribeFromTopic:withCompletionHandler:")]
        void UnsubscribeFromTopic(string topic, [NullAllowed] MQTTCompletionErrorBlock completionHandler);
    }

    // @interface MASAuthenticationProvider : MASObject
    [BaseType(typeof(MASObject))]
    interface MASAuthenticationProvider
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier", ArgumentSemantic.Copy)]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nonnull authenticationUrl;
        [Export("authenticationUrl", ArgumentSemantic.Copy)]
        NSUrl AuthenticationUrl { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nullable pollUrl;
        [NullAllowed, Export("pollUrl", ArgumentSemantic.Copy)]
        NSUrl PollUrl { get; }

        // -(id)isEnterprise;
        [Export("isEnterprise")]
        //[Verify(MethodToProperty)]
        NSObject IsEnterprise { get; }

        // -(id)isFacebook;
        [Export("isFacebook")]
        //[Verify(MethodToProperty)]
        NSObject IsFacebook { get; }

        // -(id)isGoogle;
        [Export("isGoogle")]
        //[Verify(MethodToProperty)]
        NSObject IsGoogle { get; }

        // -(id)isLinkedIn;
        [Export("isLinkedIn")]
        //[Verify(MethodToProperty)]
        NSObject IsLinkedIn { get; }

        // -(id)isQrCode;
        [Export("isQrCode")]
        //[Verify(MethodToProperty)]
        NSObject IsQrCode { get; }

        // -(id)isSalesforce;
        [Export("isSalesforce")]
        //[Verify(MethodToProperty)]
        NSObject IsSalesforce { get; }
    }

    // @interface MASAuthenticationProviders : MASObject
    [BaseType(typeof(MASObject))]
    interface MASAuthenticationProviders
    {
        // @property (readonly, copy, nonatomic) NSArray * _Nullable providers;
        [NullAllowed, Export("providers", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSArray[] Providers { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable idp;
        [NullAllowed, Export("idp")]
        string Idp { get; }

        // +(MASAuthenticationProviders * _Nullable)currentProviders;
        [Static]
        [NullAllowed, Export("currentProviders")]
        //[Verify(MethodToProperty)]
        MASAuthenticationProviders CurrentProviders { get; }

        // +(void)retrieveAuthenticationProvidersWithCompletion:(MASObjectResponseErrorBlock _Nullable)completion;
        [Static]
        [Export("retrieveAuthenticationProvidersWithCompletion:")]
        void RetrieveAuthenticationProvidersWithCompletion([NullAllowed] MASObjectResponseErrorBlock completion);

        // -(MASAuthenticationProvider * _Nullable)retrieveAuthenticationProviderForProximityLogin;
        [NullAllowed, Export("retrieveAuthenticationProviderForProximityLogin")]
        //[Verify(MethodToProperty)]
        MASAuthenticationProvider RetrieveAuthenticationProviderForProximityLogin { get; }
    }

    // @protocol MASAuthorizationResponseDelegate <NSObject>
    //[Protocol, Model]
    [BaseType(typeof(NSObject))]
    [Model]
    interface MASAuthorizationResponseDelegate
    {
        // @required -(void)didReceiveAuthorizationCode:(NSString * _Nonnull)code;
        [Abstract]
        [Export("didReceiveAuthorizationCode:")]
        void DidReceiveAuthorizationCode(string code);

        // @required -(void)didReceiveError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("didReceiveError:")]
        void DidReceiveError(NSError error);
    }

    // @interface MASAuthorizationResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface MASAuthorizationResponse
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MASAuthorizationResponseDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MASAuthorizationResponseDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // +(instancetype _Nullable)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        [return: NullAllowed]
        MASAuthorizationResponse SharedInstance();

        // -(BOOL)application:(UIApplication * _Nonnull)app openURL:(NSURL * _Nonnull)url options:(NSDictionary<UIApplicationOpenURLOptionsKey,id> * _Nonnull)options;
        [Export("application:openURL:options:")]
        bool Application(UIApplication app, NSUrl url, NSDictionary<NSString, NSObject> options);

        // -(BOOL)application:(UIApplication * _Nonnull)application openURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nonnull)sourceApplication annotation:(id _Nonnull)annotation;
        [Export("application:openURL:sourceApplication:annotation:")]
        bool Application(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation);
    }

    // @interface MASConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface MASConfiguration
    {
        // @property (readonly, assign, nonatomic) BOOL isLoaded;
        [Export("isLoaded")]
        bool IsLoaded { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull applicationName;
        [Export("applicationName", ArgumentSemantic.Strong)]
        string ApplicationName { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull applicationType;
        [Export("applicationType", ArgumentSemantic.Strong)]
        string ApplicationType { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable applicationDescription;
        [NullAllowed, Export("applicationDescription", ArgumentSemantic.Strong)]
        string ApplicationDescription { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull applicationOrganization;
        [Export("applicationOrganization", ArgumentSemantic.Strong)]
        string ApplicationOrganization { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull applicationRegisteredBy;
        [Export("applicationRegisteredBy", ArgumentSemantic.Strong)]
        string ApplicationRegisteredBy { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable gatewayCertificates;
        [NullAllowed, Export("gatewayCertificates", ArgumentSemantic.Copy)]
        string[] GatewayCertificates { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable trustedCertPinnedPublickKeyHashes;
        [NullAllowed, Export("trustedCertPinnedPublickKeyHashes", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSArray[] TrustedCertPinnedPublickKeyHashes { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable gatewayCertificatesAsDERData;
        [NullAllowed, Export("gatewayCertificatesAsDERData", ArgumentSemantic.Copy)]
        string[] GatewayCertificatesAsDERData { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable gatewayCertificatesAsPEMData;
        [NullAllowed, Export("gatewayCertificatesAsPEMData", ArgumentSemantic.Copy)]
        string[] GatewayCertificatesAsPEMData { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull gatewayHostName;
        [Export("gatewayHostName", ArgumentSemantic.Strong)]
        string GatewayHostName { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull gatewayPort;
        [Export("gatewayPort", ArgumentSemantic.Strong)]
        NSNumber GatewayPort { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable gatewayPrefix;
        [NullAllowed, Export("gatewayPrefix", ArgumentSemantic.Strong)]
        string GatewayPrefix { get; }

        // @property (readonly, nonatomic, strong) NSURL * _Nonnull gatewayUrl;
        [Export("gatewayUrl", ArgumentSemantic.Strong)]
        NSUrl GatewayUrl { get; }

        // @property (readonly, assign, nonatomic) BOOL locationIsRequired;
        [Export("locationIsRequired")]
        bool LocationIsRequired { get; }

        // @property (readonly, assign, nonatomic) BOOL enabledPublicKeyPinning;
        [Export("enabledPublicKeyPinning")]
        bool EnabledPublicKeyPinning { get; }

        // @property (readonly, assign, nonatomic) BOOL enabledTrustedPublicPKI;
        [Export("enabledTrustedPublicPKI")]
        bool EnabledTrustedPublicPKI { get; }

        // @property (assign, nonatomic) BOOL ssoEnabled;
        [Export("ssoEnabled")]
        bool SsoEnabled { get; set; }

        // +(MASConfiguration * _Nullable)currentConfiguration;
        [Static]
        [NullAllowed, Export("currentConfiguration")]
        //[Verify(MethodToProperty)]
        MASConfiguration CurrentConfiguration { get; }

        // -(NSString * _Nullable)endpointPathForKey:(NSString * _Nonnull)endpointKey;
        [Export("endpointPathForKey:")]
        [return: NullAllowed]
        string EndpointPathForKey(string endpointKey);

        // +(BOOL)setSecurityConfiguration:(MASSecurityConfiguration * _Nonnull)securityConfiguration error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("setSecurityConfiguration:error:")]
        bool SetSecurityConfiguration(MASSecurityConfiguration securityConfiguration, [NullAllowed] out NSError error);

        // +(void)removeSecurityConfigurationForDomain:(NSURL * _Nonnull)domain;
        [Static]
        [Export("removeSecurityConfigurationForDomain:")]
        void RemoveSecurityConfigurationForDomain(NSUrl domain);

        // +(NSArray * _Nullable)securityConfigurations;
        [Static]
        [NullAllowed, Export("securityConfigurations")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSArray[] SecurityConfigurations { get; }

        // +(MASSecurityConfiguration * _Nullable)securityConfigurationForDomain:(NSURL * _Nonnull)domain;
        [Static]
        [Export("securityConfigurationForDomain:")]
        [return: NullAllowed]
        MASSecurityConfiguration SecurityConfigurationForDomain(NSUrl domain);

        // @property (readonly, assign, nonatomic) BOOL applicationCredentialsAreDynamic;
        [Export("applicationCredentialsAreDynamic")]
        bool ApplicationCredentialsAreDynamic { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSDictionary *> * _Nonnull applicationClients;
        [Export("applicationClients", ArgumentSemantic.Copy)]
        NSDictionary[] ApplicationClients { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable scimPathEndpointPath;
        [NullAllowed, Export("scimPathEndpointPath")]
        string ScimPathEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable storagePathEndpointPath;
        [NullAllowed, Export("storagePathEndpointPath")]
        string StoragePathEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable authorizationEndpointPath;
        [NullAllowed, Export("authorizationEndpointPath")]
        string AuthorizationEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable clientInitializeEndpointPath;
        [NullAllowed, Export("clientInitializeEndpointPath")]
        string ClientInitializeEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable authenticateOTPEndpointPath;
        [NullAllowed, Export("authenticateOTPEndpointPath")]
        string AuthenticateOTPEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable deviceListAllEndpointPath;
        [NullAllowed, Export("deviceListAllEndpointPath")]
        string DeviceListAllEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable deviceRegisterEndpointPath;
        [NullAllowed, Export("deviceRegisterEndpointPath")]
        string DeviceRegisterEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable deviceRegisterClientEndpointPath;
        [NullAllowed, Export("deviceRegisterClientEndpointPath")]
        string DeviceRegisterClientEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable deviceRenewEndpointPath;
        [NullAllowed, Export("deviceRenewEndpointPath")]
        string DeviceRenewEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable deviceRemoveEndpointPath;
        [NullAllowed, Export("deviceRemoveEndpointPath")]
        string DeviceRemoveEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable enterpriseBrowserEndpointPath;
        [NullAllowed, Export("enterpriseBrowserEndpointPath")]
        string EnterpriseBrowserEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable tokenEndpointPath;
        [NullAllowed, Export("tokenEndpointPath")]
        string TokenEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable tokenRevokeEndpointPath;
        [NullAllowed, Export("tokenRevokeEndpointPath")]
        string TokenRevokeEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable userInfoEndpointPath;
        [NullAllowed, Export("userInfoEndpointPath")]
        string UserInfoEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable userSessionLogoutEndpointPath;
        [NullAllowed, Export("userSessionLogoutEndpointPath")]
        string UserSessionLogoutEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable userSessionStatusEndpointPath;
        [NullAllowed, Export("userSessionStatusEndpointPath")]
        string UserSessionStatusEndpointPath { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable bluetoothServiceUuid;
        [NullAllowed, Export("bluetoothServiceUuid")]
        string BluetoothServiceUuid { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable bluetoothCharacteristicUuid;
        [NullAllowed, Export("bluetoothCharacteristicUuid")]
        string BluetoothCharacteristicUuid { get; }

        // @property (readonly, assign) NSInteger bluetoothRssi;
        [Export("bluetoothRssi")]
        nint BluetoothRssi { get; }

        // -(instancetype _Nullable)initWithConfigurationInfo:(NSDictionary * _Nonnull)info;
        [Export("initWithConfigurationInfo:")]
        IntPtr Constructor(NSDictionary info);

        // +(MASConfiguration * _Nullable)instanceFromStorage;
        [Static]
        [NullAllowed, Export("instanceFromStorage")]
        //[Verify(MethodToProperty)]
        MASConfiguration InstanceFromStorage { get; }

        // -(void)saveToStorage;
        [Export("saveToStorage")]
        void SaveToStorage();

        // -(void)reset;
        [Export("reset")]
        void Reset();

        // -(NSString * _Nonnull)defaultApplicationClientIdentifier;
        [Export("defaultApplicationClientIdentifier")]
        //[Verify(MethodToProperty)]
        string DefaultApplicationClientIdentifier { get; }

        // -(NSString * _Nullable)defaultApplicationClientSecret;
        [NullAllowed, Export("defaultApplicationClientSecret")]
        //[Verify(MethodToProperty)]
        string DefaultApplicationClientSecret { get; }

        // -(NSDictionary<NSString *,NSString *> * _Nonnull)defaultApplicationClientInfo;
        [Export("defaultApplicationClientInfo")]
        //[Verify(MethodToProperty)]
        NSDictionary<NSString, NSString> DefaultApplicationClientInfo { get; }

        // -(BOOL)compareWithCurrentConfiguration:(NSDictionary * _Nonnull)newConfiguration;
        [Export("compareWithCurrentConfiguration:")]
        bool CompareWithCurrentConfiguration(NSDictionary newConfiguration);

        // -(BOOL)detectServerChangeWithCurrentConfiguration:(NSDictionary * _Nonnull)newConfiguration;
        [Export("detectServerChangeWithCurrentConfiguration:")]
        bool DetectServerChangeWithCurrentConfiguration(NSDictionary newConfiguration);

        // +(NSError * _Nullable)validateJSONConfiguration:(NSDictionary * _Nonnull)configuration;
        [Static]
        [Export("validateJSONConfiguration:")]
        [return: NullAllowed]
        NSError ValidateJSONConfiguration(NSDictionary configuration);

        // +(void)setSecurityConfiguration:(MASSecurityConfiguration * _Nonnull)securityConfiguration __attribute__((deprecated("[MASConfiguration setSecurityConfiguration:] is deprecated.  Use [MASConfiguration setSecurityConfiguration:error:] instead for better handling of error cases.")));
        [Static]
        [Export("setSecurityConfiguration:")]
        void SetSecurityConfiguration(MASSecurityConfiguration securityConfiguration);
    }

    // @interface MASDevice : MASObject
    /// <summary>
    /// The `MASDevice` class is a local representation of device data.
    /// </summary>
    [BaseType(typeof(MASObject))]
    interface MASDevice
    {
        // @property (readonly, assign, nonatomic) BOOL isRegistered;
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:MASFoundation.MASDevice"/> is registered.
        /// </summary>
        /// <value><c>true</c> if is registered; otherwise, <c>false</c>.</value>
        [Export("isRegistered")]
        bool IsRegistered { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        /// <summary>
        /// The MASDevice identifier.
        /// </summary>
        /// <value>The device identifier.</value>
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        /// <summary>
        /// Gets the MASDevice name.
        /// </summary>
        /// <value>The MASDevice name.</value>
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable status;
        /// <summary>
        /// Gets the MASDevice status.
        /// </summary>
        /// <value>The MASDevice status.</value>
        [NullAllowed, Export("status")]
        string Status { get; }

        // @property (assign) BOOL isBeingAuthorized;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:MASFoundation.MASDevice"/> is being authorized with other devices through proximity login.
        /// </summary>
        /// <value><c>true</c> if is being authorized; otherwise, <c>false</c>.</value>
        [Export("isBeingAuthorized")]
        bool IsBeingAuthorized { get; set; }

        // +(id<MASProximityLoginDelegate> _Nullable)proximityLoginDelegate;
        // +(void)setProximityLoginDelegate:(id<MASProximityLoginDelegate> _Nonnull)delegate;
        /// <summary>
        /// Gets or sets the proximity login delegate.
        /// </summary>
        /// <value>The proximity login delegate.</value>
        [Static]
        [NullAllowed, Export("proximityLoginDelegate")]
        //[Verify(MethodToProperty)]
        MASProximityLoginDelegate ProximityLoginDelegate { get; set; }

        // +(MASDevice * _Nullable)currentDevice;
        /// <summary>
        /// The device the application is running on. This is a singleton object.
        /// </summary>
        /// <returns>A singleton 'MASDevice' object.</returns>
        [Static]
        [Export("currentDevice")]
        [return: NullAllowed]
        MASDevice CurrentDevice();

        // -(void)deregisterWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Deregister the application resources on this device. This is a two step operation.
        /// 
        /// It will first attempt to remove the device's registered record in the cloud.  If it fails,
        /// an error is returned and the appropriate notification is sent and it will stop there.
        /// 
        /// Upon success of the first operation, deregistration in the cloud, it will then attempt to
        /// wipe the device of all credential settings.  If it fails, an error is returned and the appropriate
        /// notification is sent.It will stop here.
        /// 
        /// *  WARNING #1: 
        /// 
        ///     A call to deregistration in the same session as the device was initially registered will
        ///     fail and may leave the device in a strange state.This call should work post
        ///     initial registration and a restart of the application.
        /// 
        /// * WARNING #2: 
        /// 
        ///     A successful call to deregistration will leave the current application session
        ///     without required credentials and settings.  You must restart the application
        ///     to re-register the application and retrieve new credentials.
        /// 
        /// This should be considered an advanced feature.If you make this available to end users it
        /// should not be made too easily accessible and the UI control should be marked and possibly labeled
        /// to accentuate that it will wipe settings both in the cloud and locally on the device. We
        /// recommend you also provide an additional user confirmation UI component to make it clear to 
        /// the user what will occur and allow them to cancel the operation or proceed.
        /// 
        /// Although an asynchronous block callback parameter is provided for detecting the response,
        /// optionally you can set that to nil and the caller can observe the lifecycle notifications instead.
        /// </summary>
        /// <param name="completion">Completion.</param>
        [Export("deregisterWithCompletion:")]
        void DeregisterWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)resetLocally;
        /// <summary>
        /// Reset the application's locally stored data on the device only.  This does NOT call the
        /// backend service to remove the device record.You must call MASDevice.CurrentDevice().DeregisterWithCompletion() to do that.
        /// 
        /// WARNING: if you call this method, all access credentials and locally stored configuration related to the application will be removed.
        /// Re-authentication proccess will be triggered whenever you are trying to access the gateway.
        /// </summary>
        [Export("resetLocally")]
        void ResetLocally();

        // -(void)startAsBluetoothPeripheral;
        /// <summary>
        /// Start the device acting as a bluetooth peripheral.
        /// </summary>
        [Export("startAsBluetoothPeripheral")]
        void StartAsBluetoothPeripheral();

        // -(void)stopAsBluetoothPeripheral;
        /// <summary>
        /// Stop the device acting as a bluetooth peripheral.
        /// </summary>
        [Export("stopAsBluetoothPeripheral")]
        void StopAsBluetoothPeripheral();

        // -(void)startAsBluetoothCentral;
        /// <summary>
        /// Start the device acting as a bluetooth central.
        /// </summary>
        [Export("startAsBluetoothCentral")]
        void StartAsBluetoothCentral();

        // -(void)startAsBluetoothCentralWithAuthenticationProvider:(MASAuthenticationProvider * _Nonnull)provider;
        /// <summary>
        /// Start the device acting as a bluetooth central with given authentication provider.
        /// </summary>
        /// <param name="provider">MASAuthenticationProvider to pass authentication information to other devices.</param>
        [Export("startAsBluetoothCentralWithAuthenticationProvider:")]
        void StartAsBluetoothCentralWithAuthenticationProvider(MASAuthenticationProvider provider);

        // -(void)stopAsBluetoothCentral;
        /// <summary>
        /// Stop the device acting as a bluetooth central.
        /// </summary>
        [Export("stopAsBluetoothCentral")]
        void StopAsBluetoothCentral();
    }

    // @interface MASFile : MASObject
    [BaseType(typeof(MASObject))]
    interface MASFile
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic, strong) NSData * _Nonnull contents;
        [Export("contents", ArgumentSemantic.Strong)]
        NSData Contents { get; }

        // @property (readonly, assign, nonatomic) NSString * _Nonnull filePath;
        [Export("filePath")]
        string FilePath { get; }

        // @property (readonly, assign) MASFileDirectoryType directoryType;
        [Export("directoryType", ArgumentSemantic.Assign)]
        MASFileDirectoryType DirectoryType { get; }

        // +(MASFile * _Nullable)fileWithName:(NSString * _Nonnull)name contents:(NSData * _Nonnull)contents;
        [Static]
        [Export("fileWithName:contents:")]
        [return: NullAllowed]
        MASFile FileWithName(string name, NSData contents);

        // +(MASFile * _Nullable)fileWithName:(NSString * _Nonnull)name contents:(NSData * _Nonnull)contents directoryType:(MASFileDirectoryType)directoryType;
        [Static]
        [Export("fileWithName:contents:directoryType:")]
        [return: NullAllowed]
        MASFile FileWithName(string name, NSData contents, MASFileDirectoryType directoryType);

        // +(MASFile * _Nullable)findFileWithName:(NSString * _Nonnull)name;
        [Static]
        [Export("findFileWithName:")]
        [return: NullAllowed]
        MASFile FindFileWithName(string name);

        // +(MASFile * _Nullable)findFileWithName:(NSString * _Nonnull)name directoryType:(MASFileDirectoryType)directoryType;
        [Static]
        [Export("findFileWithName:directoryType:")]
        [return: NullAllowed]
        MASFile FindFileWithName(string name, MASFileDirectoryType directoryType);

        // -(BOOL)save;
        [Export("save")]
        //[Verify(MethodToProperty)]
        //bool Save { get; }
        bool Save();

        // -(BOOL)saveWithDataWritingOption:(NSDataWritingOptions)option;
        [Export("saveWithDataWritingOption:")]
        bool SaveWithDataWritingOption(NSDataWritingOptions option);

        // -(BOOL)remove;
        [Export("remove")]
        //[Verify(MethodToProperty)]
        //bool Remove { get; }
        bool Remove();

        // +(BOOL)removeItemAtFilePath:(NSString * _Nonnull)filePath;
        [Static]
        [Export("removeItemAtFilePath:")]
        bool RemoveItemAtFilePath(string filePath);

        // +(NSString * _Nullable)storeTemporaryItem:(NSData * _Nonnull)data;
        [Static]
        [Export("storeTemporaryItem:")]
        [return: NullAllowed]
        string StoreTemporaryItem(NSData data);
    }

    // @interface MASGroup : MASObject
    [BaseType(typeof(MASObject))]
    interface MASGroup
    {
        // @property (readwrite, copy, nonatomic) NSString * _Nonnull groupName;
        [Export("groupName")]
        string GroupName { get; set; }

        // @property (readwrite, copy, nonatomic) NSString * _Nullable owner;
        [NullAllowed, Export("owner")]
        string Owner { get; set; }

        // @property (readwrite, copy, nonatomic) NSArray * _Nullable members;
        [NullAllowed, Export("members", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSArray[] Members { get; set; }

        // -(instancetype _Nullable)initWithInfo:(NSDictionary * _Nonnull)info;
        [Export("initWithInfo:")]
        IntPtr Constructor(NSDictionary info);

        // +(MASGroup * _Nullable)group;
        [Static]
        [NullAllowed, Export("group")]
        //[Verify(MethodToProperty)]
        MASGroup Group { get; }
    }

    // @interface MASProximityLogin : MASObject
    [BaseType(typeof(MASObject))]
    interface MASProximityLogin
    {
    }

    // @interface MASProximityLoginQRCode : MASProximityLogin
    [BaseType(typeof(MASProximityLogin))]
    interface MASProximityLoginQRCode
    {
        // @property (readonly, assign, nonatomic) NSNumber * _Nonnull pollingInterval;
        [Export("pollingInterval", ArgumentSemantic.Assign)]
        NSNumber PollingInterval { get; }

        // @property (readonly, assign, nonatomic) NSNumber * _Nonnull pollingDelay;
        [Export("pollingDelay", ArgumentSemantic.Assign)]
        NSNumber PollingDelay { get; }

        // @property (readonly, assign, nonatomic) NSNumber * _Nonnull pollingLimit;
        [Export("pollingLimit", ArgumentSemantic.Assign)]
        NSNumber PollingLimit { get; }

        // @property (readonly, assign, nonatomic) int currentPollingCounter;
        [Export("currentPollingCounter")]
        int CurrentPollingCounter { get; }

        // @property (readonly, assign, nonatomic) BOOL isPolling;
        [Export("isPolling")]
        bool IsPolling { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull authenticationUrl;
        [Export("authenticationUrl")]
        string AuthenticationUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull pollUrl;
        [Export("pollUrl")]
        string PollUrl { get; }

        // -(instancetype _Nullable)initWithAuthenticationProvider:(MASAuthenticationProvider * _Nonnull)provider initialDelay:(NSNumber * _Nonnull)initDelay pollingInterval:(NSNumber * _Nonnull)pollingInterval pollingLimit:(NSNumber * _Nonnull)pollingLimit;
        [Export("initWithAuthenticationProvider:initialDelay:pollingInterval:pollingLimit:")]
        IntPtr Constructor(MASAuthenticationProvider provider, NSNumber initDelay, NSNumber pollingInterval, NSNumber pollingLimit);

        // -(instancetype _Nullable)initWithAuthenticationProvider:(MASAuthenticationProvider * _Nonnull)provider;
        [Export("initWithAuthenticationProvider:")]
        IntPtr Constructor(MASAuthenticationProvider provider);

        // -(UIImage * _Nullable)startDisplayingQRCodeImageForProximityLogin;
        [NullAllowed, Export("startDisplayingQRCodeImageForProximityLogin")]
        //[Verify(MethodToProperty)]
        //UIImage StartDisplayingQRCodeImageForProximityLogin { get; }
        UIImage StartDisplayingQRCodeImageForProximityLogin();

        // -(void)stopDisplayingQRCodeImageForProximityLogin;
        [Export("stopDisplayingQRCodeImageForProximityLogin")]
        void StopDisplayingQRCodeImageForProximityLogin();

        // +(void)authorizeAuthenticateUrl:(NSString * _Nonnull)authenticateUrl completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        [Export("authorizeAuthenticateUrl:completion:")]
        void AuthorizeAuthenticateUrl(string authenticateUrl, [NullAllowed] MASCompletionErrorBlock completion);
    }

    // @interface MASSharedStorage : MASObject
    [BaseType(typeof(MASObject))]
    interface MASSharedStorage
    {
        // +(NSString * _Nullable)findStringUsingKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("findStringUsingKey:error:")]
        [return: NullAllowed]
        string FindStringUsingKey(string key, [NullAllowed] out NSError error);

        // +(NSData * _Nullable)findDataUsingKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("findDataUsingKey:error:")]
        [return: NullAllowed]
        NSData FindDataUsingKey(string key, [NullAllowed] out NSError error);

        // +(BOOL)saveString:(NSString * _Nonnull)string key:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("saveString:key:error:")]
        bool SaveString(string @string, string key, [NullAllowed] out NSError error);

        // +(BOOL)saveData:(NSData * _Nonnull)data key:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("saveData:key:error:")]
        bool SaveData(NSData data, string key, [NullAllowed] out NSError error);

        // +(void)deleteForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("deleteForKey:error:")]
        void DeleteForKey(string key, [NullAllowed] out NSError error);
    }

    // @protocol MASSocialLoginDelegate <NSObject>
    //[Protocol, Model]
    [BaseType(typeof(NSObject))]
    [Model]
    interface MASSocialLoginDelegate
    {
        // @required -(void)didReceiveAuthorizationCode:(NSString *)code __attribute__((deprecated("")));
        [Abstract]
        [Export("didReceiveAuthorizationCode:")]
        void DidReceiveAuthorizationCode(string code);

        // @optional -(void)didReceiveError:(NSError *)error __attribute__((deprecated("")));
        [Export("didReceiveError:")]
        void DidReceiveError(NSError error);

        // @optional -(void)didStartLoadingWebView __attribute__((deprecated("")));
        [Export("didStartLoadingWebView")]
        void DidStartLoadingWebView();

        // @optional -(void)didStopLoadingWebView __attribute__((deprecated("")));
        [Export("didStopLoadingWebView")]
        void DidStopLoadingWebView();
    }

    // @interface MASSocialLogin : MASObject
    [BaseType(typeof(MASObject))]
    interface MASSocialLogin
    {
        // @property (nonatomic, strong) MASAuthenticationProvider * provider __attribute__((deprecated("")));
        [Export("provider", ArgumentSemantic.Strong)]
        MASAuthenticationProvider Provider { get; set; }

        [Wrap("WeakDelegate")]
        MASSocialLoginDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MASSocialLoginDelegate> delegate __attribute__((deprecated("")));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype)initWithAuthenticationProvider:(MASAuthenticationProvider *)provider webView:(WKWebView *)webView __attribute__((deprecated("")));
        [Export("initWithAuthenticationProvider:webView:")]
        IntPtr Constructor(MASAuthenticationProvider provider, WKWebView webView);
    }

    // @interface MASUser : MASObject
    /// <summary>
    /// The `MASUser` class is a local representation of user data.
    /// </summary>
    [BaseType(typeof(MASObject))]
    interface MASUser
    {
        // @property (readonly, assign, nonatomic) BOOL isCurrentUser;
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:MASFoundation.MASUser"/> is current user.
        /// </summary>
        /// <value><c>true</c> if is current user; otherwise, <c>false</c>.</value>
        [Export("isCurrentUser")]
        bool IsCurrentUser { get; }

        // @property (readonly, assign, nonatomic) BOOL isAuthenticated;
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:MASFoundation.MASUser"/> is authenticated.
        /// </summary>
        /// <value><c>true</c> if is authenticated; otherwise, <c>false</c>.</value>
        [Export("isAuthenticated")]
        bool IsAuthenticated { get; }

        // @property (readonly, assign, nonatomic) BOOL isSessionLocked;
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:MASFoundation.MASUser"/>'s session is locked.
        /// </summary>
        /// <value><c>true</c> if is session locked; otherwise, <c>false</c>.</value>
        [Export("isSessionLocked")]
        bool IsSessionLocked { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull userName;
        /// <summary>
        /// Gets the string value of the username.
        /// </summary>
        /// <value>The string value of the username.</value>
        [Export("userName")]
        string UserName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable familyName;
        /// <summary>
        /// Gets the string value of family name.
        /// </summary>
        /// <value>The string value of family name.</value>
        [NullAllowed, Export("familyName")]
        string FamilyName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable givenName;
        /// <summary>
        /// Gets the string value of given name.
        /// </summary>
        /// <value>The string value of given name.</value>
        [NullAllowed, Export("givenName")]
        string GivenName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable formattedName;
        /// <summary>
        /// Gets the string value of formatted name.
        /// </summary>
        /// <value>The string value of formatted name.</value>
        [NullAllowed, Export("formattedName")]
        string FormattedName { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable emailAddresses;
        /// <summary>
        /// Gets the email addresses.
        /// </summary>
        /// <value>The email addresses.</value>
        [NullAllowed, Export("emailAddresses", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> EmailAddresses { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable phoneNumbers;
        /// <summary>
        /// Gets the phone numbers.
        /// </summary>
        /// <value>The phone numbers.</value>
        [NullAllowed, Export("phoneNumbers", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> PhoneNumbers { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable addresses;
        /// <summary>
        /// Gets the addresses.
        /// </summary>
        /// <value>The addresses.</value>
        [NullAllowed, Export("addresses", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Addresses { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable photos;
        /// <summary>
        /// Gets the photos.
        /// </summary>
        /// <value>The photos.</value>
        [NullAllowed, Export("photos", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Photos { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable groups;
        /// <summary>
        /// Gets the groups.
        /// </summary>
        /// <value>The groups.</value>
        [NullAllowed, Export("groups", ArgumentSemantic.Copy)]
        string[] Groups { get; }

        // @property (readonly, assign, nonatomic) BOOL active;
        [Export("active")]
        bool Active { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable accessToken;
        /// <summary>
        /// Gets the access token of the user, if authenticated.
        /// </summary>
        /// <value>The access token.</value>
        [NullAllowed, Export("accessToken")]
        string AccessToken { get; }

        // +(MASUser * _Nullable)currentUser;
        /// <summary>
        /// GeThe authenticated user for the application, if any. null returned if none. This is a singleton object.
        /// </summary>
        /// <value>A singleton 'MASUser' object.</value>
        [Static]
        [NullAllowed, Export("currentUser")]
        //[Verify(MethodToProperty)]
        MASUser CurrentUser { get; }

        // +(NSString * _Nullable)authCredentialsType;
        /// <summary>
        /// Previously, or currently used authCredentialsType for the session.
        /// If the SDK is not properly initialized, nil will be returned regardless of the authentication status of the SDK.
        /// If the SDK was never authenticated before, SDK will also return nil as a result.
        /// </summary>
        /// <value>NSString of previously, or currently used authCredentialsType as in String.</value>
        [Static]
        [NullAllowed, Export("authCredentialsType")]
        //[Verify(MethodToProperty)]
        string AuthCredentialsType { get; }

        // -(void)lockSessionWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Lock currently authenticated user session with device's local authentication (Device's Passcode or Biometric Authentication).
        /// 
        /// This will lock current user session and block most of operations except for MASUser.CurrentUser.LogoutWithCompletion();
        /// and MASDevice.CurrentDevice().DeregisterWithCompletion().
        /// Alternatively, locked user session can be removed by MASUser.CurrentUser.RemoveSessionLock()
        /// which will remove credentials from protected stroage of the device with local authentication.
        /// 
        /// After locking user session, MASUser.CurrentUser will still exists; 
        /// however, MASUser.CurrentUser.IsAuthenticated property will reflect the lock status and will return false until it's unlocked.
        /// Session lock status can also be checked through MASUser.CurrentUser.isSessionLocked property.
        /// </summary>
        /// <param name="completion">The MASCompletionErrorBlock block that receives the results.</param>
        [Export("lockSessionWithCompletion:")]
        void LockSessionWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)unlockSessionWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Unlcok currently locked user session with device's local authentication (Device's Passcode or Biometric Authentication).
        /// 
        /// This will unlock current user session and unblock all of the operations through SDK.
        /// 
        /// After unlocking user session, MASUser.CurrentUser will reflect correct authentication and lock status.
        /// </summary>
        /// <param name="completion">MASCompletionErrorBlock block that receives the results.</param>
        [Export("unlockSessionWithCompletion:")]
        void UnlockSessionWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)unlockSessionWithUserOperationPromptMessage:(NSString * _Nonnull)userOperationPrompt completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Unlock currently locked user session with device's local authentication (Device's Passcode or Biometric Authentication) and specified message on system local authentication dialog.
        /// 
        /// This will unlock current user session and unblock all of the operations through SDK.
        /// 
        /// After unlocking user session, MASUser.CurrentUser will reflect correct authentication and lock status.
        /// </summary>
        /// <param name="userOperationPrompt">NSString message that will be displayed on system local authentication dialog.</param>
        /// <param name="completion">MASCompletionErrorBlock block that receives the results.</param>
        [Export("unlockSessionWithUserOperationPromptMessage:completion:")]
        void UnlockSessionWithUserOperationPromptMessage(string userOperationPrompt, [NullAllowed] MASCompletionErrorBlock completion);

        // -(void)removeSessionLock;
        /// <summary>
        /// Remove user session that had been protected device's local authentication.
        /// 
        /// This interface can be used when end-user chooses to not provide local authentication and clean up the session.
        /// </summary>
        [Export("removeSessionLock")]
        void RemoveSessionLock();

        // +(void)loginWithUserName:(NSString * _Nonnull)userName password:(NSString * _Nonnull)password completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Authenticate a user via asynchronous request with basic credentials.
        /// 
        /// This will create an MASUser.CurrentUser upon a successful result.  
        /// </summary>
        /// <param name="userName">The userName of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="completion">The MASCompletionErrorBlock block that receives the results.  On a successful completion, the user available via MASUser.CurrentUser has been updated with the new information.</param>
        [Static]
        [Export("loginWithUserName:password:completion:")]
        void LoginWithUserName(string userName, string password, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)loginWithAuthorizationCode:(NSString * _Nonnull)authorizationCode completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Authenticate a user via asynchronous request with authorization code.
        /// 
        /// This will create an MASUser.CurrentUser upon a successful result.  
        /// </summary>
        /// <param name="authorizationCode">The authorization code for the user.</param>
        /// <param name="completion">The MASCompletionErrorBlock block that receives the results.  On a successful completion, the user available via MASUser.CurrentUser has been updated with the new information.</param>
        [Static]
        [Export("loginWithAuthorizationCode:completion:")]
        void LoginWithAuthorizationCode(string authorizationCode, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)loginWithIdToken:(NSString * _Nonnull)idToken tokenType:(NSString * _Nonnull)tokenType completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Authenticate a user via asynchronous request with id_token.
        /// 
        /// This will create an MASUser.CurrentUser upon a successful result.  
        /// </summary>
        /// <param name="idToken">The id_token for the user.</param>
        /// <param name="tokenType">Token type of id_token.</param>
        /// <param name="completion">The MASCompletionErrorBlock block that receives the results.  On a successful completion, the user available via MASUser.CurrentUser has been updated with the new information.</param>
        [Static]
        [Export("loginWithIdToken:tokenType:completion:")]
        void LoginWithIdToken(string idToken, string tokenType, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)loginWithAuthCredentials:(MASAuthCredentials * _Nonnull)authCredentials completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        ///  Authenticate a user via asynchronous request with MASAuthCredentials object.
        /// This will accept any objects that inherites from MASAuthCredentials and all MASAuthCredentials objects that adheres device registration/user authentication logics
        /// on backend services.
        /// 
        /// This will create an MASUser.CurrentUser upon a successful result.  
        /// </summary>
        /// <param name="authCredentials">MASAuthCredentials object that contains credentials.</param>
        /// <param name="completion">The MASCompletionErrorBlock block that receives the results.  On a successful completion, the user available via MASUser.CurrentUser has been updated with the new information.</param>
        [Static]
        [Export("loginWithAuthCredentials:completion:")]
        void LoginWithAuthCredentials(MASAuthCredentials authCredentials, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)initializeBrowserBasedAuthenticationWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Authenticate a user by launching a Browser which in turn loads a URL (templatized).
        /// </summary>
        /// <param name="completion">The MASCompletionErrorBlock block that receives the results.  On a successful completion, the user available via MASUser.CurrentUser has been updated with the new information.</param>
        [Static]
        [Export("initializeBrowserBasedAuthenticationWithCompletion:")]
        void InitializeBrowserBasedAuthenticationWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)requestUserInfoWithCompletion:(MASUserResponseErrorBlock _Nullable)completion;
        /// <summary>
        /// Requesting userInfo for the MASUser object.
        /// This method will retrieve additional information on the MASUser object.
        /// </summary>
        /// <param name="completion">The MASUserResponseErrorBlock block that returns MASUSer object with updated value which is also available through the current MASUser object that is making this request, and NSError object in case any error is encountered during the process.</param>
        [Export("requestUserInfoWithCompletion:")]
        void RequestUserInfoWithCompletion([NullAllowed] MASUserResponseErrorBlock completion);

        // -(void)logoutWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Logout an already authenticated user via asynchronous request.
        /// 
        /// This will return <c>true</c> upon a successful result.
        /// </summary>
        /// <param name="completion">The MASCompletionErrorBlock block that receives the results.  On a successful completion, the user 
        /// available via[MASUser currentUser] has been updated with the new information.</param>
        [Export("logoutWithCompletion:")]
        void LogoutWithCompletion([NullAllowed] MASCompletionErrorBlock completion);
    }

    // @interface MAS (NSData)
    [BaseType(typeof(NSData))]
    [Category]
    interface NSData_MAS
    {
        // +(NSData * _Nullable)encryptData:(NSData * _Nonnull)data password:(NSString * _Nonnull)password error:(NSError * _Nullable * _Nullable)anError;
        [Static]
        [Export("encryptData:password:error:")]
        [return: NullAllowed]
        NSData EncryptData(NSData data, string password, [NullAllowed] out NSError anError);

        // +(NSData * _Nullable)decryptData:(NSData * _Nonnull)data password:(NSString * _Nonnull)password error:(NSError * _Nullable * _Nullable)anError;
        [Static]
        [Export("decryptData:password:error:")]
        [return: NullAllowed]
        NSData DecryptData(NSData data, string password, [NullAllowed] out NSError anError);

        // -(BOOL)isEncrypted;
        [Static]
        [Export("isEncrypted")]
        //[Verify(MethodToProperty)]
        bool IsEncrypted { get; }
    }

    // @interface MASClaims : MASObject
    [BaseType(typeof(MASObject))]
    interface MASClaims
    {
        // @property (readwrite, nonatomic, strong) NSString * _Nullable iss;
        [NullAllowed, Export("iss", ArgumentSemantic.Strong)]
        string Iss { get; set; }

        // @property (readwrite, nonatomic, strong) NSString * _Nullable aud;
        [NullAllowed, Export("aud", ArgumentSemantic.Strong)]
        string Aud { get; set; }

        // @property (readwrite, nonatomic, strong) NSString * _Nullable sub;
        [NullAllowed, Export("sub", ArgumentSemantic.Strong)]
        string Sub { get; set; }

        // @property (readwrite, nonatomic, strong) NSDate * _Nullable exp;
        [NullAllowed, Export("exp", ArgumentSemantic.Strong)]
        NSDate Exp { get; set; }

        // @property (readwrite, nonatomic, strong) NSDate * _Nullable iat;
        [NullAllowed, Export("iat", ArgumentSemantic.Strong)]
        NSDate Iat { get; set; }

        // @property (readwrite, nonatomic, strong) NSDate * _Nullable nbf;
        [NullAllowed, Export("nbf", ArgumentSemantic.Strong)]
        NSDate Nbf { get; set; }

        // @property (readwrite, nonatomic, strong) NSString * _Nullable jti;
        [NullAllowed, Export("jti", ArgumentSemantic.Strong)]
        string Jti { get; set; }

        // @property (readwrite, nonatomic, strong) id _Nullable content;
        [NullAllowed, Export("content", ArgumentSemantic.Strong)]
        NSObject Content { get; set; }

        // @property (readwrite, nonatomic, strong) NSString * _Nullable contentType;
        [NullAllowed, Export("contentType", ArgumentSemantic.Strong)]
        string ContentType { get; set; }

        // @property (readonly, nonatomic, strong) NSMutableDictionary * _Nullable customClaims;
        [NullAllowed, Export("customClaims", ArgumentSemantic.Strong)]
        NSMutableDictionary CustomClaims { get; }

        // -(void)setValue:(id _Nonnull)value forClaimKey:(NSString * _Nonnull)claimKey error:(NSError * _Nullable * _Nullable)error;
        [Export("setValue:forClaimKey:error:")]
        void SetValue(NSObject value, string claimKey, [NullAllowed] out NSError error);

        // +(MASClaims * _Nullable)claims;
        [Static]
        [NullAllowed, Export("claims")]
        //[Verify(MethodToProperty)]
        MASClaims Claims { get; }
    }

    // @interface MASRequestBuilder : MASObject
    /// <summary>
    ///  MASRequestBuilder class is an object that allows developers to progressively build a request as needed.
    /// The class is mainly responsible to receive parameters and create a MASRequest object.
    /// 
    /// Default configuration value for designated initializer, new MASRequestBuilder("GET/PUT/POST/DELETE"), would be:
    /// isPublic: <c>false</c>,
    /// sign: <c>false</c>,
    /// requestType:MASRequestResponseType.Json, 
    /// responseType:MASRequestResponseType.Json.
    /// </summary>
    [BaseType(typeof(MASObject))]
    interface MASRequestBuilder
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull httpMethod;
        /// <summary>
        /// NSString value of the HTTP Method (GET, POST, PUT, DELETE).
        /// </summary>
        /// <value>The http method.</value>
        [Export("httpMethod", ArgumentSemantic.Strong)]
        string HttpMethod { get; }

        // @property (assign) BOOL isPublic;
        /// <summary>
        /// bool value that determines whether or not to include credentials of primary gateway in the request.
        /// </summary>
        /// <value><c>true</c> if is public; otherwise, <c>false</c>.</value>
        [Export("isPublic")]
        bool IsPublic { get; set; }

        // @property (readonly, assign) BOOL sign;
        /// <summary>
        /// bool value that determines whether or not digitally sign the request parameters with JWT signature.
        /// </summary>
        /// <value><c>true</c> if sign; otherwise, <c>false</c>.</value>
        [Export("sign")]
        bool Sign { get; }

        // @property (nonatomic, strong) NSString * _Nullable endPoint;
        /// <summary>
        /// NSString value of the target endpoint.
        /// </summary>
        /// <value>The end point.</value>
        [NullAllowed, Export("endPoint", ArgumentSemantic.Strong)]
        string EndPoint { get; set; }

        // @property (readonly, nonatomic, strong) MASClaims * _Nullable claims;
        /// <summary>
        /// MASClaims object containing claims for JWT.
        /// </summary>
        /// <value>The claims.</value>
        [NullAllowed, Export("claims", ArgumentSemantic.Strong)]
        MASClaims Claims { get; }

        // @property (readonly, nonatomic, strong) NSData * _Nullable privateKey;
        /// <summary>
        /// NSData value of private key.
        /// </summary>
        /// <value>The private key.</value>
        [NullAllowed, Export("privateKey", ArgumentSemantic.Strong)]
        NSData PrivateKey { get; }

        // @property (nonatomic, strong) NSDictionary * _Nullable header;
        /// <summary>
        /// NSDictionary of type/value parameters to put into the header of a request.
        /// </summary>
        /// <value>The header.</value>
        [NullAllowed, Export("header", ArgumentSemantic.Strong)]
        NSDictionary Header { get; set; }

        // @property (nonatomic, strong) NSDictionary * _Nullable body;
        /// <summary>
        /// NSDictionary of type/value parameters to put into the body of a request.
        /// </summary>
        /// <value>The body.</value>
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        NSDictionary Body { get; set; }

        // @property (nonatomic, strong) NSDictionary * _Nullable query;
        /// <summary>
        /// NSDictionary of type/value parameters to put into the URL of a request.
        /// </summary>
        /// <value>The query.</value>
        [NullAllowed, Export("query", ArgumentSemantic.Strong)]
        NSDictionary Query { get; set; }

        // @property (assign) MASRequestResponseType requestType;
        /// <summary>
        /// MASRequestResponseType value that specifies what type formatting is required for request body.
        /// </summary>
        /// <value>The type of the request.</value>
        [Export("requestType", ArgumentSemantic.Assign)]
        MASRequestResponseType RequestType { get; set; }

        // @property (assign) MASRequestResponseType responseType;
        /// <summary>
        /// MASRequestResponseType value that specifies what type formatting is required for response body.
        /// </summary>
        /// <value>The type of the response.</value>
        [Export("responseType", ArgumentSemantic.Assign)]
        MASRequestResponseType ResponseType { get; set; }

        // -(instancetype _Nonnull)initWithHTTPMethod:(NSString * _Nonnull)method __attribute__((objc_designated_initializer));
        /// <summary>
        /// Designated initializer for MASRequestBuilder.
        /// </summary>
        /// <returns>MASRequestBuilder object.</returns>
        /// <param name="method">NSString of the HTTP Method (GET, POST, PUT, DELETE).</param>
        [Export("initWithHTTPMethod:")]
        [DesignatedInitializer]
        IntPtr Constructor(string method);

        // -(MASRequest * _Nullable)build;
        /// <summary>
        /// Create a MASRequest object using the parameters from MASRequestBuider
        /// </summary>
        /// <returns>MASRequest object.</returns>
        [NullAllowed, Export("build")]
        //[Verify(MethodToProperty)]
        //MASRequest Build { get; }
        MASRequest Build();

        // -(void)setSignWithError:(NSError * _Nullable * _Nullable)error;
        /// <summary>
        /// Set to sign the body of request using default private key from device registration against primary gateway.
        /// </summary>
        /// <param name="error">NSError error reference object that returns any error occurred during JWT signature.</param>
        [Export("setSignWithError:")]
        void SetSignWithError([NullAllowed] out NSError error);

        // -(void)setSignWithClaims:(MASClaims * _Nonnull)claims error:(NSError * _Nullable * _Nullable)error;
        /// <summary>
        /// Set to sign the request with a MASClaims object using default private key from device registration against primary gateway.
        /// </summary>
        /// <param name="claims">MASClaims object containing claims for JWT</param>
        /// <param name="error">NSError error reference object that returns any error occurred during JWT signature.</param>
        [Export("setSignWithClaims:error:")]
        void SetSignWithClaims(MASClaims claims, [NullAllowed] out NSError error);

        // -(void)setSignWithClaims:(MASClaims * _Nonnull)claims privateKey:(NSData * _Nonnull)privateKey error:(NSError * _Nullable * _Nullable)error;
        /// <summary>
        /// Set to sign the request with a MASClaims object using custom private key in NSData format.
        /// </summary>
        /// <param name="claims">MASClaims object containing claims for JWT</param>
        /// <param name="privateKey">Custom private key in NSData format signed using RS256 algorithm.</param>
        /// <param name="error">NSError error reference object that returns any error occurred during JWT signature.</param>
        [Export("setSignWithClaims:privateKey:error:")]
        void SetSignWithClaims(MASClaims claims, NSData privateKey, [NullAllowed] out NSError error);

        // -(void)setHeaderParameter:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        /// <summary>
        /// Append parameter into the header of a request.
        /// </summary>
        /// <param name="key">NSString containing name/type of the parameter.</param>
        /// <param name="value">NSString containing value of the parameter.</param>
        [Export("setHeaderParameter:value:")]
        void SetHeaderParameter(string key, string value);

        // -(void)setBodyParameter:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        /// <summary>
        /// Append parameter into the body of a request.
        /// </summary>
        /// <param name="key">NSString containing name/type of the parameter.</param>
        /// <param name="value">NSString containing value of the parameter.</param>
        [Export("setBodyParameter:value:")]
        void SetBodyParameter(string key, string value);

        // -(void)setQueryParameter:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        /// <summary>
        /// Append parameter into the URL of a request.
        /// </summary>
        /// <param name="key">NSString containing name/type of the parameter.</param>
        /// <param name="value">NSString containing value of the parameter.M</param>
        [Export("setQueryParameter:value:")]
        void SetQueryParameter(string key, string value);
    }

    // @interface MASRequest : MASObject
    /// <summary>
    /// MASRequest class is an object created by MASRequestBuilder. It contains all necessary information to invoke an API.
    /// The class cannot be constructed or changed directly, only through MASRequestBuilder.
    /// </summary>
    [BaseType(typeof(MASObject))]
    interface MASRequest
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull httpMethod;
        /// <summary>
        /// NSString value of the HTTP Method (GET, POST, PUT, DELETE).
        /// </summary>
        /// <value>The http method.</value>
        [Export("httpMethod", ArgumentSemantic.Strong)]
        string HttpMethod { get; }

        // @property (readonly, assign) BOOL isPublic;
        /// <summary>
        /// BOOL value that determines whether or not to include credentials of primary gateway in the request.
        /// </summary>
        /// <value><c>true</c> if is public; otherwise, <c>false</c>.</value>
        [Export("isPublic")]
        bool IsPublic { get; }

        // @property (readonly, assign) BOOL sign;
        /// <summary>
        /// bool value that determines whether or not digitally sign the request parameters with JWT signature.
        /// </summary>
        /// <value><c>true</c> if sign; otherwise, <c>false</c>.</value>
        [Export("sign")]
        bool Sign { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable endPoint;
        /// <summary>
        /// NSString value of the specific end point path fragment to append to the base Gateway URL.  endPoint value can also be defined as full URL format; in this case,
        /// SDK must be configured to add add the external host as a trusted source using MASSecurityConfiguration object.
        /// </summary>
        /// <value>The end point.</value>
        [NullAllowed, Export("endPoint", ArgumentSemantic.Strong)]
        string EndPoint { get; }

        // @property (readonly, nonatomic, strong) NSData * _Nullable privateKey;
        /// <summary>
        /// NSData value of private key.
        /// </summary>
        /// <value>The private key.</value>
        [NullAllowed, Export("privateKey", ArgumentSemantic.Strong)]
        NSData PrivateKey { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * _Nullable header;
        /// <summary>
        /// NSDictionary of type/value parameters to put into the header of a request.
        /// </summary>
        /// <value>The header.</value>
        [NullAllowed, Export("header", ArgumentSemantic.Strong)]
        NSDictionary Header { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * _Nullable body;
        /// <summary>
        /// NSDictionary of type/value parameters to put into the body of a request.
        /// </summary>
        /// <value>The body.</value>
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        NSDictionary Body { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * _Nullable query;
        /// <summary>
        /// NSDictionary of type/value parameters to put into the URL of a request.
        /// </summary>
        /// <value>The query.</value>
        [NullAllowed, Export("query", ArgumentSemantic.Strong)]
        NSDictionary Query { get; }

        // @property (readonly, assign) MASRequestResponseType requestType;
        /// <summary>
        /// MASRequestResponseType value that specifies what type formatting is required for request body.
        /// </summary>
        /// <value>The type of the request.</value>
        [Export("requestType", ArgumentSemantic.Assign)]
        MASRequestResponseType RequestType { get; }

        // @property (readonly, assign) MASRequestResponseType responseType;
        /// <summary>
        /// MASRequestResponseType value that specifies what type formatting is required for response body.
        /// </summary>
        /// <value>The type of the response.</value>
        [Export("responseType", ArgumentSemantic.Assign)]
        MASRequestResponseType ResponseType { get; }

        // +(instancetype _Nullable)deleteFrom:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        /// <summary>
        /// Initialize MASRequest using MASRequestBuilder block and defining the request method as a HTTP DELETE call. This type of HTTP Method type
        /// places its parameters within the NSURL itself as an HTTP query extension.
        /// </summary>
        /// <remarks>
        /// default values for designated initializer are: isPublic: NO, sign: NO, requestType:MASRequestResponseTypeJson, responseType:MASRequestResponseTypeJson.
        /// </remarks>
        /// <returns>MASRequestBuilder object.</returns>
        /// <param name="block">MASRequestBuilder block containing all paramters to build the request.</param>
        [Static]
        [Export("deleteFrom:")]
        [return: NullAllowed]
        MASRequest DeleteFrom(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)getFrom:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        /// <summary>
        /// Initialize MASRequest using MASRequestBuilder block and defining the request method as a HTTP GET call. This type of HTTP Method type
        /// places its parameters within the NSURL itself as an HTTP query extension.
        /// </summary>
        /// <remarks>
        /// default values for designated initializer are: isPublic: NO, sign: NO, requestType:MASRequestResponseTypeJson, responseType:MASRequestResponseTypeJson.
        /// </remarks>
        /// <returns>MASRequestBuilder object.</returns>
        /// <param name="block">MASRequestBuilder block containing all paramters to build the request.</param>
        [Static]
        [Export("getFrom:")]
        [return: NullAllowed]
        MASRequest GetFrom(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)patchTo:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        /// <summary>
        /// Initialize MASRequest using MASRequestBuilder block and defining the request method as a HTTP PATCH call. This type of HTTP Method type
        /// places its parameters within the NSURL itself as an HTTP query extension.
        /// </summary>
        /// <remarks>
        /// default values for designated initializer are: isPublic: NO, sign: NO, requestType:MASRequestResponseTypeJson, responseType:MASRequestResponseTypeJson.
        /// </remarks>
        /// <returns>MASRequestBuilder object.</returns>
        /// <param name="block">MASRequestBuilder block containing all paramters to build the request.</param>
        [Static]
        [Export("patchTo:")]
        [return: NullAllowed]
        MASRequest PatchTo(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)postTo:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        /// <summary>
        /// Initialize MASRequest using MASRequestBuilder block and defining the request method as a HTTP POST call. This type of HTTP Method type
        /// places its parameters within the NSURL itself as an HTTP query extension.
        /// </summary>
        /// <remarks>
        /// default values for designated initializer are: isPublic: NO, sign: NO, requestType:MASRequestResponseTypeJson, responseType:MASRequestResponseTypeJson.
        /// </remarks>
        /// <returns>MASRequestBuilder object.</returns>
        /// <param name="block">MASRequestBuilder block containing all paramters to build the request.</param>
        [Static]
        [Export("postTo:")]
        [return: NullAllowed]
        MASRequest PostTo(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)putTo:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        /// <summary>
        /// Initialize MASRequest using MASRequestBuilder block and defining the request method as a HTTP PUT call. This type of HTTP Method type
        /// places its parameters within the NSURL itself as an HTTP query extension.
        /// </summary>
        /// <remarks>
        /// default values for designated initializer are: isPublic: NO, sign: NO, requestType:MASRequestResponseTypeJson, responseType:MASRequestResponseTypeJson.
        /// </remarks>
        /// <returns>MASRequestBuilder object.</returns>
        /// <param name="block">MASRequestBuilder block containing all paramters to build the request.</param>
        [Static]
        [Export("putTo:")]
        [return: NullAllowed]
        MASRequest PutTo(Action<MASRequestBuilder> block);
    }

    // @interface MAS : NSObject
    /// <summary>
    /// The top level MAS object represents the Mobile App Services SDK in it's entirety.  
    /// It is where the framework lifecycle begins, and ends if necessary.It is the front
    /// facing class where many of the configuration settings for the SDK as a whole can be
    /// found and utilized.
    /// </summary>
    [BaseType(typeof(NSObject))]
    interface MAS
    {
        // +(void)setConfigurationFileName:(NSString * _Nonnull)fileName;
        /// <summary>
        /// Set the name of the configuration file.  This gives the ability to set the file's name to a custom value.
        /// </summary>
        /// <param name="fileName">The NSString name of the configuration file.</param>
        [Static]
        [Export("setConfigurationFileName:")]
        void SetConfigurationFileName(string fileName);

        // +(MASGrantFlow)grantFlow;
        // +(void)setGrantFlow:(MASGrantFlow)grantFlow;
        /// <summary>
        /// MASGrantFlow property.  The default is MASGrantFlow.ClientCredentials.
        /// </summary>
        /// <value>The grant flow of MAG SDK.</value>
        [Static]
        [Export("grantFlow")]
        //[Verify(MethodToProperty)]
        MASGrantFlow GrantFlow { get; set; }

        // +(void)enablePKCE:(BOOL)enable;
        /// <summary>
        /// Sets bool indicator of PKCE (Proof Key for Code Exchange) enabled or not for authorization process in Social Login, and Proximity Login.
        /// By default, PKCE is enabled and enforced in authorization process; it can be opted-out.
        /// 
        /// @since MAS Client SDK 1.4 and MAG/OTK 4.0 on April 2017 release.
        /// @dependency Minimum version of MAG/OTK 4.0 is required to successfully perform PKCE.If the server side does not support PKCE, client side will still work without PKCE verification.
        /// </summary>
        /// <param name="enable">BOOL value of indicating whether PKCE is enabled or not.</param>
        [Static]
        [Export("enablePKCE:")]
        void EnablePKCE(bool enable);

        // +(BOOL)isPKCEEnabled;
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:MASFoundation.MAS"/> is PKCEE nabled.
        /// 
        /// @since MAS Client SDK 1.4 and MAG/OTK 4.0 on April 2017 release.
        /// @dependency Minimum version of MAG/OTK 4.0 is required to successfully perform PKCE.If the server side does not support PKCE, client side will still work without PKCE verification.
        /// </summary>
        /// <value>
        /// BOOL value of indicating whether PKCE is enabled or not.
        /// <c>true</c> if is PKCEE nabled; otherwise, <c>false</c>.
        /// </value>
        [Static]
        [Export("isPKCEEnabled")]
        //[Verify(MethodToProperty)]
        bool IsPKCEEnabled { get; }

        // +(void)setUserAuthCredentials:(MASUserAuthCredentialsBlock _Nullable)userAuthCredentialsBlock;
        /// <summary>
        /// Set a user auth credential block to handle the case where SDK requires auth credentials.
        /// When MASGrantFlow is set to MASGrantFlowPassword, and auth credentials is required, SDK will invoke this block
        /// to obtain MASAuthCredentials to proceed authentication process.
        /// </summary>
        /// <param name="userAuthCredentialsBlock">MASUserAuthCredentialsBlock that contains callback block to be invoked with MASAuthCredentials.</param>
        [Static]
        [Export("setUserAuthCredentials:")]
        void SetUserAuthCredentials([NullAllowed] MASUserAuthCredentialsBlock userAuthCredentialsBlock);

        // +(void)setOTPChannelSelectionBlock:(MASOTPChannelSelectionBlock _Nullable)OTPChannelSelector;
        [Static]
        [Export("setOTPChannelSelectionBlock:")]
        void SetOTPChannelSelectionBlock([NullAllowed] MASOTPChannelSelectionBlock OTPChannelSelector);

        // +(void)setOTPCredentialsBlock:(MASOTPCredentialsBlock _Nullable)oneTimePassword;
        [Static]
        [Export("setOTPCredentialsBlock:")]
        void SetOTPCredentialsBlock([NullAllowed] MASOTPCredentialsBlock oneTimePassword);

        // +(void)enableBrowserBasedAuthentication:(BOOL)enable;
        /// <summary>
        /// Sets bool indicator of Browser Based Authentication (templatized login) enabled or not for authorization process.
        /// By default, it is disabled.
        /// </summary>
        /// <param name="enable">bool value indicating whether Browser Based Authentication is enabled or not.</param>
        [Static]
        [Export("enableBrowserBasedAuthentication:")]
        void EnableBrowserBasedAuthentication(bool enable);

        // +(void)setGatewayMonitor:(MASGatewayMonitorStatusBlock _Nullable)monitor;
        /// <summary>
        /// Sets the gateway monitoring block defined by the GatewayMonitorStatusBlock type.
        /// This block will be triggered when any change to the current monitoring status
        /// takes place with a MASGatewayMonitoringStatus.
        /// 
        /// This is optional and it can be set to nil at any time to stop receiving the notifications.
        /// </summary>
        /// <remarks>
        /// The gateway monitoring status enumerated values are:
        /// MASGatewayMonitoringStatus.ewayMonitoringStatusNotReachable
        /// MASGatewayMonitoringStatus.ewayMonitoringStatusReachableViaWWAN
        /// MASGatewayMonitoringStatus.ewayMonitoringStatusReachableViaWiFi
        /// </remarks>
        /// <param name="monitor">The MASGatewayMonitorStatusBlock that will receive the status updates.</param>
        [Static]
        [Export("setGatewayMonitor:")]
        void SetGatewayMonitor([NullAllowed] MASGatewayMonitorStatusBlock monitor);

        // +(MASState)MASState;
        /// <summary>
        /// Returns current MASState enumeration value.  The value can be used to determine which state SDK is currently at.
        /// </summary>
        /// <value>MASState of current state.</value>
        [Static]
        [Export("MASState")]
        //[Verify(MethodToProperty)]
        MASState MASState { get; }

        // +(void)setGatewayNetworkActivityLogging:(BOOL)enabled;
        /// <summary>
        /// Turn on or off the logging of the network activity with the Gateway.
        /// </summary>
        /// <param name="enabled">If set to <c>true</c> enabled.</param>
        [Static]
        [Export("setGatewayNetworkActivityLogging:")]
        void SetGatewayNetworkActivityLogging(bool enabled);

        // +(void)setKeychainSynchronizable:(BOOL)enabled;
        /// <summary>
        /// Sets bool indicator whether the Keychain is synchronized through iCloud.
        /// By default, the Keychain is not synchronized through iCloud.
        /// </summary>
        /// <param name="enabled">If set to <c>true</c> enabled.</param>
        [Static]
        [Export("setKeychainSynchronizable:")]
        void SetKeychainSynchronizable(bool enabled);

        // +(BOOL)isKeychainSynchronizable;
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:MASFoundation.MAS"/> is keychain synchronizable.
        /// </summary>
        /// <value><c>true</c> if is keychain synchronizable; otherwise, <c>false</c>.</value>
        [Static]
        [Export("isKeychainSynchronizable")]
        //[Verify(MethodToProperty)]
        bool IsKeychainSynchronizable { get; }

        // +(void)start:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Starts the lifecycle of the MAS processes.  
        /// 
        /// Although an asynchronous block callback parameter is provided for response usage,
        /// optionally you can set that to nil and the caller can observe the lifecycle 
        /// notifications instead.
        /// 
        /// This will load the last used JSON configuration from keychain storage.If there was none,
        /// it will load from default JSON configuration file (msso_config.json)
        /// or JSON file with file name set through[MAS setConfigurationFileName:].
        /// </summary>
        /// <remarks>
        /// The MAS lifecycle notifications are:
        /// 
        ///  *      MASWillStartNotification
        ///  *      MASDidFailToStartNotification
        ///  *      MASDidStartNotification
        /// 
        /// The application registration notifications are:
        /// 
        ///  *      MASApplicationWillRegisterNotification
        ///  *      MASApplicationDidFailToRegisterNotification
        ///  *      MASApplicationDidRegisterNotification
        /// </remarks>
        /// <param name="completion">An MASCompletionErrorBlock type (bool completed, NSError error) that will
        /// receive a <c>true</c> or <c>false</c> BOOL indicating the completion state and/or an NSError object if there
        /// is a failure.
        /// </param>
        [Static]
        [Export("start:")]
        void Start([NullAllowed] MASCompletionErrorBlock completion);

        // +(void)startWithDefaultConfiguration:(BOOL)shouldUseDefault completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Starts the lifecycle of the MAS processes.
        /// 
        /// Although an asynchronous block callback parameter is provided for response usage,
        /// optionally you can set that to nil and the caller can observe the lifecycle
        /// notifications instead.
        /// 
        /// This will load the default JSON configuration rather than from keychain storage; if the SDK was already initialized, this method will fully stop and re-start the SDK.
        /// The default JSON configuration file should be msso_config.json or file name defined through MAS.SetConfigurationFileName().
        /// This will ignore the JSON configuration in keychain storage and replace with the default configuration.
        /// </summary>
        /// <remarks>
        /// The MAS lifecycle notifications are:
        /// 
        ///  *      MASWillStartNotification
        ///  *      MASDidFailToStartNotification
        ///  *      MASDidStartNotification
        /// 
        /// The application registration notifications are:
        /// 
        ///  *      MASApplicationWillRegisterNotification
        ///  *      MASApplicationDidFailToRegisterNotification
        ///  *      MASApplicationDidRegisterNotification
        /// </remarks>
        /// <param name="shouldUseDefault">Boolean value of using default configuration rather than the one in keychain storage.</param>
        /// <param name="completion">An MASCompletionErrorBlock type (bool completed, NSError error) that will
        /// receive a <c>true</c> or <c>false</c> BOOL indicating the completion state and/or an NSError object if there
        /// is a failure.
        /// </param>
        [Static]
        [Export("startWithDefaultConfiguration:completion:")]
        void StartWithDefaultConfiguration(bool shouldUseDefault, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)startWithJSON:(NSDictionary * _Nonnull)jsonConfiguration completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Starts the lifecycle of the MAS processes with given JSON configuration data.
        /// This method will overwrite JSON configuration(if they are different) that was stored in keychain.
        /// 
        /// Although an asynchronous block callback parameter is provided for response usage,
        /// optionally you can set that to nil and the caller can observe the lifecycle
        /// </summary>
        /// <remarks>
        /// The MAS lifecycle notifications are:
        /// 
        ///  *      MASWillStartNotification
        ///  *      MASDidFailToStartNotification
        ///  *      MASDidStartNotification
        /// 
        /// The application registration notifications are:
        /// 
        ///  *      MASApplicationWillRegisterNotification
        ///  *      MASApplicationDidFailToRegisterNotification
        ///  *      MASApplicationDidRegisterNotification
        /// </remarks>
        /// <param name="jsonConfiguration">NSDictionary of JSON configuration object.</param>
        /// <param name="completion">An MASCompletionErrorBlock type (bool completed, NSError error) that will
        /// receive a <c>true</c> or <c>false</c> BOOL indicating the completion state and/or an NSError object if there
        /// is a failure.</param>
        [Static]
        [Export("startWithJSON:completion:")]
        void StartWithJSON(NSDictionary jsonConfiguration, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)startWithURL:(NSURL * _Nullable)url completion:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Starts the lifecycle of the MAS processes with given JSON configuration file path, enrolment URL or nil.
        /// This method will overwrite JSON configuration(if they are different) that was stored in keychain when configuration file path or enrolment URL is provided.
        /// 
        /// When URL is recognized as nil, this method will initialize SDK by using last used JSON configuration that is stored in keychain storage,
        /// or load JSON configuration from defined default configuration file name.
        /// 
        /// 
        /// Enrolment URL is an URL from gateway containing some of credentials required to establish secure connection.
        /// 
        /// The gateway must be configured to generate and handle enrolment process with client side SDK.
        /// The enrolment URL can be retrieved in many ways which has to be configured properly along with the gateway in regards of the enrolment process.
        /// 
        /// MASFoundation SDK does not request, or retrieve the enrolment URL by itself.
        /// 
        /// Although an asynchronous block callback parameter is provided for response usage,
        /// 
        /// optionally you can set that to nil and the caller can observe the lifecycle
        /// </summary>
        /// <remarks>
        /// The MAS lifecycle notifications are:
        /// 
        /// *      MASWillStartNotification
        /// *      MASDidFailToStartNotification
        /// *      MASDidStartNotification
        /// 
        /// The application registration notifications are:
        /// 
        /// *      MASApplicationWillRegisterNotification
        /// *      MASApplicationDidFailToRegisterNotification
        /// *      MASApplicationDidRegisterNotification
        /// </remarks>
        /// <param name="url">NSURL of JSON configuration file path or enrolment URL.</param>
        /// <param name="completion">An MASCompletionErrorBlock type (BOOL completed, NSError *error) that will receive a <c>true</c> or <c>false</c> BOOL indicating the completion state and/or an NSError object if there is a failure.</param>
        [Static]
        [Export("startWithURL:completion:")]
        void StartWithURL([NullAllowed] NSUrl url, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)stop:(MASCompletionErrorBlock _Nullable)completion;
        /// <summary>
        /// Stops the lifecycle of all MAS processes.
        /// 
        /// Although an asynchronous block callback parameter is provided for response usage,
        /// optionally you can set that to nil and the caller can observe the lifecycle 
        /// notifications instead.
        /// </summary>
        /// <remarks>
        /// The lifecycle notifications are:
        /// 
        /// *      MASWillStopNotification
        /// *      MASDidFailToStopNotification
        /// *      MASDidStopNotification
        /// </remarks>
        /// <param name="completion">An MASCompletionErrorBlock type (bool completed, NSError error) that will
        /// receive a <c>true</c> or <c>false</c> BOOL indicating the completion state and/or an NSError object if there
        /// is a failure.
        /// </param>
        [Static]
        [Export("stop:")]
        void Stop([NullAllowed] MASCompletionErrorBlock completion);

        // +(BOOL)gatewayIsReachable;
        /// <summary>
        /// Retrieves a simple boolean indicator if the gateway is currently reachable or not.
        /// </summary>
        /// <value><c>true</c> if gateway is reachable; otherwise, <c>false</c>.</value>
        [Static]
        [Export("gatewayIsReachable")]
        //[Verify(MethodToProperty)]
        bool GatewayIsReachable { get; }

        // +(NSString * _Nonnull)gatewayMonitoringStatusAsString;
        /// <summary>
        /// Retrieves the current gateway monitoring status of the Gateway connection.
        /// </summary>
        /// <remarks>
        /// The monitoring status enumerated values to their string equivalents are:
        /// 
        /// MASGatewayMonitoringStatus.ewayMonitoringStatusNotReachable
        /// MASGatewayMonitoringStatus.ewayMonitoringStatusReachableViaWWAN
        /// MASGatewayMonitoringStatus.ewayMonitoringStatusReachableViaWiFi
        /// </remarks>
        /// <value>The gateway monitoring status as string.</value>
        [Static]
        [Export("gatewayMonitoringStatusAsString")]
        //[Verify(MethodToProperty)]
        string GatewayMonitoringStatusAsString { get; }

        // +(void)deleteFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP DELETE call from the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use MAS.DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// 
        /// This version defaults the request/response content type encoding to JSON.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("deleteFrom:withParameters:andHeaders:completion:")]
        void DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)deleteFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP DELETE call from the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use MAS.DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// 
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("deleteFrom:withParameters:andHeaders:requestType:responseType:completion:")]
        void DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)deleteFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP DELETE call from the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// 
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="isPublic">Boolean value whether the request is being made outside of primary gateway. When the value is set to true, all automatically injected credentials in SDK will be excluded in the request.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("deleteFrom:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)getFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP GET call from the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// 
        /// This version defaults the request/response content type encoding to JSON.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("getFrom:withParameters:andHeaders:completion:")]
        void GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)getFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP GET call from the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("getFrom:withParameters:andHeaders:requestType:responseType:completion:")]
        void GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)getFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP GET call from the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="isPublic">Boolean value whether the request is being made outside of primary gateway. When the value is set to true, all automatically injected credentials in SDK will be excluded in the request.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("getFrom:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)patchTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP PATCH call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// 
        /// This version defaults the request/response content type encoding to JSON.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("patchTo:withParameters:andHeaders:completion:")]
        void PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)patchTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP PATCH call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("patchTo:withParameters:andHeaders:requestType:responseType:completion:")]
        void PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)patchTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP PATCH call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="isPublic">Boolean value whether the request is being made outside of primary gateway. When the value is set to true, all automatically injected credentials in SDK will be excluded in the request.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("patchTo:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)postTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP POST call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// 
        /// This version defaults the request/response content type encoding to JSON.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("postTo:withParameters:andHeaders:completion:")]
        void PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)postTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP POST call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("postTo:withParameters:andHeaders:requestType:responseType:completion:")]
        void PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)postTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP PATCH call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="isPublic">Boolean value whether the request is being made outside of primary gateway. When the value is set to true, all automatically injected credentials in SDK will be excluded in the request.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("postTo:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)putTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP PUT call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// 
        /// This version defaults the request/response content type encoding to JSON.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("putTo:withParameters:andHeaders:completion:")]
        void PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)putTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP PUT call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("putTo:withParameters:andHeaders:requestType:responseType:completion:")]
        void PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)putTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Request method for an HTTP PUT call to the Gateway.  This type of HTTP Method type
        /// places it's parameters within the NSURL itself as an HTTP query extension as so:
        /// 
        /// https://<hostname>:<port>/<endPointPath><?type=value&type2=value2&...>
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// If endPointPath is full URL format, upon successful SSL pinning validation, SDK will also validate the user session against primary gateway regardless the request is being made
        /// to the primary gateway or not.  To ensure bypass the user session validation for public API, use PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion) method
        /// with isPublic being <c>true</c>.
        /// </summary>
        /// <param name="endPointPath">The specific end point path fragment NSString to append to the base
        /// Gateway URL.endPointPath value can also be defined as full URL format; in this case, SDK must be configured to perform SSL pinning with public key hashes
        /// which can be configured in JSON configuration.</param>
        /// <param name="parameterInfo">An NSDictionary of key/value parameter values that will go into the query portion of the URL.</param>
        /// <param name="headerInfo">An NSDictionary of key/value header values that will go into the HTTP header.</param>
        /// <param name="requestType">The mime type content encoding expected for the parameter encoding.</param>
        /// <param name="responseType">The mime type expected in the body of the response.</param>
        /// <param name="isPublic">Boolean value whether the request is being made outside of primary gateway. When the value is set to true, all automatically injected credentials in SDK will be excluded in the request.</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("putTo:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)invoke:(MASRequest * _Nonnull)request completion:(MASResponseInfoErrorBlock _Nullable)completion;
        /// <summary>
        /// Invoke the endpoint with the parameters defined in the MASRequest object
        /// 
        /// If endPointPath is full URL format(including port number and http protocol), SDK will validate the server from the client side through SSL pinning(authentication challenge) with
        /// provided subjectKeyHash(also known as public key hash) in configuration in mag.mobile_sdk.trusted_cert_pinned_public_key_hashes and mag.mobile_sdk.enable_public_key_pinning.
        /// 
        /// ALL of servers' public key hashes in certificate chain must be defined in the list.  This means when it is configured to use public key hash pinning for SSL pinning,
        /// subjectKeyHash(public key hash) of the gateway must be also present within the list.The list can contain multiple hash values in array for multiple servers.
        /// 
        /// When SDK fails to validate SSL with certificate or subjectKeyHash pinning for communication to HTTPs, SDK will cancel the request.
        /// 
        /// </summary>
        /// <param name="request">MASRequest An object containing all parameters to call the endpoint When the value is set to true, all automatically injected credentials in SDK will be excluded in the request..</param>
        /// <param name="completion">An MASResponseInfoErrorBlock (NSDictionary responseInfo, NSError error) that will receive the JSON response object or an NSError object if there is a failure.</param>
        [Static]
        [Export("invoke:completion:")]
        void Invoke(MASRequest request, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(NSString * _Nullable)signWithClaims:(MASClaims * _Nonnull)claims error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("signWithClaims:error:")]
        [return: NullAllowed]
        string SignWithClaims(MASClaims claims, [NullAllowed] out NSError error);

        // +(NSString * _Nullable)signWithClaims:(MASClaims * _Nonnull)claims privateKey:(NSData * _Nonnull)privateKey error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("signWithClaims:privateKey:error:")]
        [return: NullAllowed]
        string SignWithClaims(MASClaims claims, NSData privateKey, [NullAllowed] out NSError error);

        // +(void)setUserLoginBlock:(MASUserLoginWithUserCredentialsBlock _Nullable)login __attribute__((deprecated("[MAS setUserLoginBlock:] is deprecated as of MAS 1.5. Use [MAS setAuthCredentials:] instead.")));
        [Static]
        [Export("setUserLoginBlock:")]
        void SetUserLoginBlock([NullAllowed] MASUserLoginWithUserCredentialsBlock login);
    }

    // @interface MASApplication : MASObject
    [BaseType(typeof(MASObject))]
    interface MASApplication
    {
        // @property (readonly, assign, nonatomic) BOOL isRegistered;
        [Export("isRegistered")]
        bool IsRegistered { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable organization;
        [NullAllowed, Export("organization")]
        string Organization { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable detailedDescription;
        [NullAllowed, Export("detailedDescription")]
        string DetailedDescription { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable iconUrl;
        [NullAllowed, Export("iconUrl")]
        string IconUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable authUrl;
        [NullAllowed, Export("authUrl")]
        string AuthUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable nativeUrl;
        [NullAllowed, Export("nativeUrl")]
        string NativeUrl { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable customProperties;
        [NullAllowed, Export("customProperties", ArgumentSemantic.Copy)]
        NSDictionary CustomProperties { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable environment;
        [NullAllowed, Export("environment")]
        string Environment { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nullable redirectUri;
        [NullAllowed, Export("redirectUri", ArgumentSemantic.Copy)]
        NSUrl RedirectUri { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable registeredBy;
        [NullAllowed, Export("registeredBy")]
        string RegisteredBy { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable scope;
        [NullAllowed, Export("scope", ArgumentSemantic.Copy)]
        string[] Scope { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable scopeAsString;
        [NullAllowed, Export("scopeAsString")]
        string ScopeAsString { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable status;
        [NullAllowed, Export("status")]
        string Status { get; }

        // @property (readonly, assign, nonatomic) BOOL isAuthenticated;
        [Export("isAuthenticated")]
        bool IsAuthenticated { get; }

        // @property (readonly, assign, nonatomic) MASAuthenticationStatus authenticationStatus;
        [Export("authenticationStatus", ArgumentSemantic.Assign)]
        MASAuthenticationStatus AuthenticationStatus { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MASEnterpriseAppProtocol Delegate { get; set; }

        // @property id<MASEnterpriseAppProtocol> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // +(MASApplication * _Nullable)currentApplication;
        [Static]
        [NullAllowed, Export("currentApplication")]
        //[Verify(MethodToProperty)]
        MASApplication CurrentApplication { get; }

        // -(void)retrieveEnterpriseApps:(MASObjectsResponseErrorBlock _Nullable)completion;
        [Export("retrieveEnterpriseApps:")]
        void RetrieveEnterpriseApps([NullAllowed] MASObjectsResponseErrorBlock completion);

        // -(void)enterpriseIconWithImageView:(UIImageView * _Nonnull)imageView completion:(MASCompletionErrorBlock _Nullable)completion;
        [Export("enterpriseIconWithImageView:completion:")]
        void EnterpriseIconWithImageView(UIImageView imageView, [NullAllowed] MASCompletionErrorBlock completion);

        // -(void)loadWebApp:(UIWebView * _Nonnull)webView completion:(MASCompletionErrorBlock _Nullable)completion;
        [Export("loadWebApp:completion:")]
        void LoadWebApp(UIWebView webView, [NullAllowed] MASCompletionErrorBlock completion);
    }

    // @protocol MASEnterpriseAppProtocol <NSObject>
    //[Protocol, Model]
    [BaseType(typeof(NSObject))]
    [Model]
    interface MASEnterpriseAppProtocol
    {
        // @required -(void)enterpriseWebApp:(MASApplication * _Nonnull)app;
        [Abstract]
        [Export("enterpriseWebApp:")]
        void EnterpriseWebApp(MASApplication app);

        // @required -(void)enterpriseApp:(MASApplication * _Nonnull)app didReceiveError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("enterpriseApp:didReceiveError:")]
        void EnterpriseApp(MASApplication app, NSError error);
    }

    // @interface MASAuthCredentials : MASObject
    [BaseType(typeof(MASObject))]
    interface MASAuthCredentials
    {
        // @property (readonly, assign, nonatomic) NSString * credentialsType;
        [Export("credentialsType")]
        string CredentialsType { get; }

        // @property (readonly, assign, nonatomic) BOOL canRegisterDevice;
        [Export("canRegisterDevice")]
        bool CanRegisterDevice { get; }

        // @property (readonly, assign, nonatomic) BOOL isReuseable;
        [Export("isReuseable")]
        bool IsReuseable { get; }

        // -(void)clearCredentials;
        [Export("clearCredentials")]
        void ClearCredentials();
    }

    // @interface MASAuthCredentialsAuthorizationCode : MASAuthCredentials
    [BaseType(typeof(MASAuthCredentials))]
    interface MASAuthCredentialsAuthorizationCode
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable authorizationCode;
        [NullAllowed, Export("authorizationCode")]
        string AuthorizationCode { get; }

        // +(MASAuthCredentialsAuthorizationCode * _Nullable)initWithAuthorizationCode:(NSString * _Nonnull)authorizationCode;
        [Static]
        [Export("initWithAuthorizationCode:")]
        [return: NullAllowed]
        MASAuthCredentialsAuthorizationCode InitWithAuthorizationCode(string authorizationCode);
    }

    // @interface MASAuthCredentialsJWT : MASAuthCredentials
    [BaseType(typeof(MASAuthCredentials))]
    interface MASAuthCredentialsJWT
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable jwt;
        [NullAllowed, Export("jwt")]
        string Jwt { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable tokenType;
        [NullAllowed, Export("tokenType")]
        string TokenType { get; }

        // +(MASAuthCredentialsJWT * _Nullable)initWithJWT:(NSString * _Nonnull)jwt tokenType:(NSString * _Nullable)tokenType;
        [Static]
        [Export("initWithJWT:tokenType:")]
        [return: NullAllowed]
        MASAuthCredentialsJWT InitWithJWT(string jwt, [NullAllowed] string tokenType);
    }

    // @interface MASAuthCredentialsPassword : MASAuthCredentials
    [BaseType(typeof(MASAuthCredentials))]
    interface MASAuthCredentialsPassword
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable username;
        [NullAllowed, Export("username")]
        string Username { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable password;
        [NullAllowed, Export("password")]
        string Password { get; }

        // +(MASAuthCredentialsPassword * _Nullable)initWithUsername:(NSString * _Nonnull)username password:(NSString * _Nonnull)password;
        [Static]
        [Export("initWithUsername:password:")]
        [return: NullAllowed]
        MASAuthCredentialsPassword InitWithUsername(string username, string password);
    }


}
