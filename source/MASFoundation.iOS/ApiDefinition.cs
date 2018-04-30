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
    /// 
    /// This API includes all features available in the native iOS SDK. Howerver, in this first release only a subset of the features are available:
    /// 
    /// Authentication and Authorization, limited to:
    ///     Device Registration
    ///     User login and client credentials
    ///     Fingerprint session lock
    ///     Single Sign-on
    /// Securely access to APIs
    /// Shared Storage
    /// 
    /// All non-supported features are commented out. If you decide to uncomment and use those fetures, do it at your own risk
    /// 

    // typedef void (^MASCompletionErrorBlock)(BOOL, NSError * _Nullable);
    delegate void MASCompletionErrorBlock(bool completed, [NullAllowed] NSError error);

    // typedef void (^MASObjectResponseErrorBlock)(id _Nullable, NSError * _Nullable);
    delegate void MASObjectResponseErrorBlock([NullAllowed] NSObject responseObject, [NullAllowed] NSError error);

    // typedef void (^MASObjectsResponseErrorBlock)(NSArray<id> * _Nullable, NSError * _Nullable);
    delegate void MASObjectsResponseErrorBlock([NullAllowed] NSObject[] objects, [NullAllowed] NSError error);

    // typedef void (^MASResponseInfoErrorBlock)(NSDictionary<NSString *,id> * _Nullable, NSError * _Nullable);
    delegate void MASResponseInfoErrorBlock([NullAllowed] NSDictionary<NSString, NSObject> responseInfo, [NullAllowed] NSError error);

    // typedef void (^MASResponseObjectErrorBlock)(NSHTTPURLResponse * _Nullable, id _Nullable, NSError * _Nullable);
    delegate void MASResponseObjectErrorBlock([NullAllowed] NSHttpUrlResponse response, [NullAllowed] NSObject responseObject, [NullAllowed] NSError error);

    // typedef void (^MASUserResponseErrorBlock)(MASUser * _Nullable, NSError * _Nullable);
    delegate void MASUserResponseErrorBlock([NullAllowed] MASUser user, [NullAllowed] NSError error);

    // typedef void (^MASAuthCredentialsBlock)(MASAuthCredentials * _Nullable, BOOL, MASCompletionErrorBlock _Nullable);
    delegate void MASAuthCredentialsBlock([NullAllowed] MASAuthCredentials authCredentials, bool cancel, [BlockCallback, NullAllowed] MASCompletionErrorBlock completionBlock);

    // typedef void (^MASUserAuthCredentialsBlock)(MASAuthCredentialsBlock _Nonnull);
    delegate void MASUserAuthCredentialsBlock([BlockCallback] MASAuthCredentialsBlock authCredentialBlock);

    //// typedef void (^MASOTPGenerationBlock)(NSArray * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASOTPGenerationBlock(NSObject[] otpChannels, bool cancel, [BlockCallback, NullAllowed] MASCompletionErrorBlock completionBlock);

    //// typedef void (^MASOTPFetchCredentialsBlock)(NSString * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASOTPFetchCredentialsBlock(string oneTimePassword, bool cancel, [BlockCallback, NullAllowed] MASCompletionErrorBlock completionBlock);

    //// typedef void (^MASOTPChannelSelectionBlock)(NSArray * _Nonnull, MASOTPGenerationBlock _Nonnull);
    //delegate void MASOTPChannelSelectionBlock(NSObject[] supportedOTPChannels, [BlockCallback] MASOTPGenerationBlock otpBotpGenerationBlocklock);

    //// typedef void (^MASOTPCredentialsBlock)(MASOTPFetchCredentialsBlock _Nonnull, NSError * _Nullable);
    //delegate void MASOTPCredentialsBlock([BlockCallback] MASOTPFetchCredentialsBlock otpBlock, [NullAllowed] NSError error);

    //// typedef void (^MASBiometricModalitiesBlock)(NSArray * _Nullable, BOOL, MASCompletionErrorBlock _Nullable);
    //delegate void MASBiometricModalitiesBlock([NullAllowed] NSObject[] biometricModalities, bool cancel, [NullAllowed] MASCompletionErrorBlock completionBlock);

    //// typedef void (^MASBiometricRegistrationModalitiesSelectionBlock)(NSArray * _Nonnull, MASBiometricModalitiesBlock _Nonnull);
    //delegate void MASBiometricRegistrationModalitiesSelectionBlock(NSObject[] availableModalities, MASBiometricModalitiesBlock biometricModalitiesBlock);

    //// typedef void (^MASBiometricDeregistrationModalitiesSelectionBlock)(NSArray * _Nonnull, MASBiometricModalitiesBlock _Nonnull);
    //delegate void MASBiometricDeregistrationModalitiesSelectionBlock(NSObject[] availableModalities, MASBiometricModalitiesBlock biometricModalitiesBlock);

    // typedef void (^MASGatewayMonitorStatusBlock)(MASGatewayMonitoringStatus);
    delegate void MASGatewayMonitorStatusBlock(MASGatewayMonitoringStatus status);

    // typedef void (^MASBasicCredentialsBlock)(NSString * _Nonnull, NSString * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    delegate void MASBasicCredentialsBlock(string userName, string password, bool cancel, [BlockCallback, NullAllowed] MASCompletionErrorBlock completionBlock);

    // typedef void (^MASAuthorizationCodeCredentialsBlock)(NSString * _Nonnull, BOOL, MASCompletionErrorBlock _Nullable);
    delegate void MASAuthorizationCodeCredentialsBlock(string authorizationCode, bool cancel, [BlockCallback, NullAllowed] MASCompletionErrorBlock completionBlock);

    // @interface MASObject : NSObject <NSCopying, NSCoding>
    [BaseType(typeof(NSObject))]
    interface MASObject : INSCopying, INSCoding
    {
        // -(instancetype _Nullable)initWithAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes;
        [Export("initWithAttributes:")]
        IntPtr Constructor(NSDictionary<NSString, NSString> attributes);

        // +(instancetype _Nullable)objectWithClassName:(NSString * _Nonnull)className;
        [Static]
        [Export("objectWithClassName:")]
        [return: NullAllowed]
        MASObject ObjectWithClassName(string className);

        // +(instancetype _Nullable)objectWithClassName:(NSString * _Nonnull)className withData:(NSDictionary<NSString *,NSString *> * _Nonnull)dictionary;
        [Static]
        [Export("objectWithClassName:withData:")]
        [return: NullAllowed]
        MASObject ObjectWithClassName(string className, NSDictionary<NSString, NSString> dictionary);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull className;
        [Export("className")]
        string ClassName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull objectId;
        [Export("objectId")]
        string ObjectId { get; }

        // @property (readonly, copy, nonatomic) NSMutableDictionary<NSString *,NSString *> * _Nonnull _attributes;
        [Export("_attributes", ArgumentSemantic.Copy)]
        NSMutableDictionary<NSString, NSString> _attributes { get; }

        // -(id _Nullable)objectForKey:(id _Nonnull)key;
        [Export("objectForKey:")]
        [return: NullAllowed]
        NSObject ObjectForKey(NSObject key);

        // -(void)setObject:(id _Nonnull)object forKey:(id<NSCopying> _Nonnull)key;
        [Export("setObject:forKey:")]
        void SetObjectForKey(NSObject @object, NSCopying key);

        // -(id _Nullable)objectForKeyedSubscript:(id _Nonnull)key;
        [Export("objectForKeyedSubscript:")]
        [return: NullAllowed]
        NSObject ObjectForKeyedSubscript(NSObject key);

        // -(void)setObject:(id _Nonnull)object forKeyedSubscript:(id<NSCopying> _Nonnull)key;
        [Export("setObject:forKeyedSubscript:")]
        void SetObjectForKeyedSubscript(NSObject @object, NSCopying key);

        // -(void)listAttributes;
        [Export("listAttributes")]
        void ListAttributes();
    }

    [Static]
    partial interface Constants
    {
        // extern double MASFoundationVersionNumber;
        [Field("MASFoundationVersionNumber", "__Internal")]
        double MASFoundationVersionNumber { get; }

        //// extern const unsigned char [] MASFoundationVersionString;
        //[Field("MASFoundationVersionStringAlias", "__Internal")]
        //IntPtr MASFoundationVersionString { get; }

        // MAS Errors
        // extern NSString *const _Nonnull MASFoundationErrorDomain;
        [Field("MASFoundationErrorDomain", "__Internal")]
        NSString MASFoundationErrorDomain { get; }

        // extern NSString *const _Nonnull MASFoundationErrorDomainLocal;
        [Field("MASFoundationErrorDomainLocal", "__Internal")]
        NSString MASFoundationErrorDomainLocal { get; }

        // extern NSString *const _Nonnull MASFoundationErrorDomainTargetAPI;
        [Field("MASFoundationErrorDomainTargetAPI", "__Internal")]
        NSString MASFoundationErrorDomainTargetAPI { get; }

        // MAS Notifications
        // extern NSString *const _Nonnull MASWillStartNotification;
        [Field("MASWillStartNotification", "__Internal")]
        NSString MASWillStartNotification { get; }

        // extern NSString *const _Nonnull MASDidFailToStartNotification;
        [Field("MASDidFailToStartNotification", "__Internal")]
        NSString MASDidFailToStartNotification { get; }

        // extern NSString *const _Nonnull MASDidStartNotification;
        [Field("MASDidStartNotification", "__Internal")]
        NSString MASDidStartNotification { get; }

        // extern NSString *const _Nonnull MASWillStopNotification;
        [Field("MASWillStopNotification", "__Internal")]
        NSString MASWillStopNotification { get; }

        // extern NSString *const _Nonnull MASDidFailToStopNotification;
        [Field("MASDidFailToStopNotification", "__Internal")]
        NSString MASDidFailToStopNotification { get; }

        // extern NSString *const _Nonnull MASDidStopNotification;
        [Field("MASDidStopNotification", "__Internal")]
        NSString MASDidStopNotification { get; }

        // extern NSString *const _Nonnull MASWillSwitchGatewayServerNotification;
        [Field("MASWillSwitchGatewayServerNotification", "__Internal")]
        NSString MASWillSwitchGatewayServerNotification { get; }

        // extern NSString *const _Nonnull MASDidSwitchGatewayServerNotification;
        [Field("MASDidSwitchGatewayServerNotification", "__Internal")]
        NSString MASDidSwitchGatewayServerNotification { get; }

        // MAS Device Notifications
        // extern NSString* const _Nonnull MASDeviceWillDeregisterNotification;
        [Field("MASDeviceWillDeregisterNotification", "__Internal")]
        NSString MASDeviceWillDeregisterNotification { get; }

        // extern NSString* const _Nonnull MASDeviceDidFailToDeregisterNotification;
        [Field("MASDeviceDidFailToDeregisterNotification", "__Internal")]
        NSString MASDeviceDidFailToDeregisterNotification { get; }

        // extern NSString* const _Nonnull MASDeviceDidDeregisterNotification;
        [Field("MASDeviceDidDeregisterNotification", "__Internal")]
        NSString MASDeviceDidDeregisterNotification { get; }

        // extern NSString* const _Nonnull MASDeviceDidResetLocallyNotification;
        [Field("MASDeviceDidResetLocallyNotification", "__Internal")]
        NSString MASDeviceDidResetLocallyNotification { get; }

        // User Notifications
        // extern NSString* const _Nonnull MASUserWillAuthenticateNotification;
        [Field("MASUserWillAuthenticateNotification", "__Internal")]
        NSString MASUserWillAuthenticateNotification { get; }

        // extern NSString* const _Nonnull MASUserDidFailToAuthenticateNotification;
        [Field("MASUserDidFailToAuthenticateNotification", "__Internal")]
        NSString MASUserDidFailToAuthenticateNotification { get; }

        // extern NSString* const _Nonnull MASUserDidAuthenticateNotification;
        [Field("MASUserDidAuthenticateNotification", "__Internal")]
        NSString MASUserDidAuthenticateNotification { get; }

        // extern NSString* const _Nonnull MASUserWillLogoutNotification;
        [Field("MASUserWillLogoutNotification", "__Internal")]
        NSString MASUserWillLogoutNotification { get; }

        // extern NSString* const _Nonnull MASUserDidFailToLogoutNotification;
        [Field("MASUserDidFailToLogoutNotification", "__Internal")]
        NSString MASUserDidFailToLogoutNotification { get; }

        // extern NSString* const _Nonnull MASUserDidLogoutNotification;
        [Field("MASUserDidLogoutNotification", "__Internal")]
        NSString MASUserDidLogoutNotification { get; }

        // extern NSString* const _Nonnull MASUserWillUpdateInformationNotification;
        [Field("MASUserWillUpdateInformationNotification", "__Internal")]
        NSString MASUserWillUpdateInformationNotification { get; }

        // extern NSString* const _Nonnull MASUserDidFailToUpdateInformationNotification;
        [Field("MASUserDidFailToUpdateInformationNotification", "__Internal")]
        NSString MASUserDidFailToUpdateInformationNotification { get; }

        // extern NSString* const _Nonnull MASUserDidUpdateInformationNotification;
        [Field("MASUserDidUpdateInformationNotification", "__Internal")]
        NSString MASUserDidUpdateInformationNotification { get; }

        //// Authorization Response - Social Login Notifications
        //// extern NSString* const _Nonnull MASAuthorizationResponseDidReceiveAuthorizationCodeNotification;
        //[Field("MASAuthorizationResponseDidReceiveAuthorizationCodeNotification", "__Internal")]
        //NSString MASAuthorizationResponseDidReceiveAuthorizationCodeNotification { get; }

        //// extern NSString* const _Nonnull MASAuthorizationResponseDidReceiveErrorNotification;
        //[Field("MASAuthorizationResponseDidReceiveErrorNotification", "__Internal")]
        //NSString MASAuthorizationResponseDidReceiveErrorNotification { get; }

        //// Proximity Login Notifications
        //// extern NSString* const _Nonnull MASDeviceDidReceiveAuthorizationCodeFromProximityLoginNotification;
        //[Field("MASDeviceDidReceiveAuthorizationCodeFromProximityLoginNotification", "__Internal")]
        //NSString MASDeviceDidReceiveAuthorizationCodeFromProximityLoginNotification { get; }

        //// extern NSString* const _Nonnull MASDeviceDidReceiveErrorFromProximityLoginNotification;
        //[Field("MASDeviceDidReceiveErrorFromProximityLoginNotification", "__Internal")]
        //NSString MASDeviceDidReceiveErrorFromProximityLoginNotification { get; }

        //// extern NSString* const _Nonnull MASProximityLoginQRCodeDidStartDisplayingQRCodeImage;
        //[Field("MASProximityLoginQRCodeDidStartDisplayingQRCodeImage", "__Internal")]
        //NSString MASProximityLoginQRCodeDidStartDisplayingQRCodeImage { get; }

        //// extern NSString* const _Nonnull MASProximityLoginQRCodeDidStopDisplayingQRCodeImage;
        //[Field("MASProximityLoginQRCodeDidStopDisplayingQRCodeImage", "__Internal")]
        //NSString MASProximityLoginQRCodeDidStopDisplayingQRCodeImage { get; }

        //Gateway Monitor Notifications
        // extern NSString* const _Nonnull MASGatewayMonitorStatusUpdateNotification;
        [Field("MASGatewayMonitorStatusUpdateNotification", "__Internal")]
        NSString MASGatewayMonitorStatusUpdateNotification { get; }
    }

    //// @protocol MASProximityLoginDelegate <NSObject>
    ////[Protocol, Model]
    //[BaseType(typeof(NSObject))]
    //[Model]
    //interface MASProximityLoginDelegate
    //{
    //    // @required -(void)handleBLEProximityLoginUserConsent:(MASCompletionErrorBlock _Nullable)completion deviceName:(NSString * _Nonnull)deviceName;
    //    [Abstract]
    //    [Export("handleBLEProximityLoginUserConsent:deviceName:")]
    //    void HandleBLEProximityLoginUserConsent([NullAllowed] MASCompletionErrorBlock completion, string deviceName);

    //    // @optional -(void)didReceiveAuthorizationCode:(NSString * _Nonnull)authorizationCode;
    //    [Export("didReceiveAuthorizationCode:")]
    //    void DidReceiveAuthorizationCode(string authorizationCode);

    //    // @optional -(void)didReceiveBLEProximityLoginStateUpdate:(MASBLEServiceState)state;
    //    [Export("didReceiveBLEProximityLoginStateUpdate:")]
    //    void DidReceiveBLEProximityLoginStateUpdate(MASBLEServiceState state);

    //    // @optional -(void)didReceiveProximityLoginError:(NSError * _Nonnull)error;
    //    [Export("didReceiveProximityLoginError:")]
    //    void DidReceiveProximityLoginError(NSError error);
    //}

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
        NSArray Certificates { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable publicKeyHashes;
        [NullAllowed, Export("publicKeyHashes", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSArray PublicKeyHashes { get; set; }

        // @property (readonly, nonatomic, strong) NSURL * _Nonnull host;
        [Export("host", ArgumentSemantic.Strong)]
        NSUrl Host { get; }

        // -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url __attribute__((objc_designated_initializer));
        [Export("initWithURL:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSUrl url);
    }


    //// typedef void (^MQTTSubscriptionCompletionHandler)(NSArray * _Nonnull);
    //delegate void MQTTSubscriptionCompletionHandler(NSArray grantedQos);

    //// typedef void (^MQTTCompletionErrorBlock)(BOOL, NSError * _Nullable);
    //delegate void MQTTCompletionErrorBlock(bool completed, [NullAllowed] NSError error);

    //// typedef void (^MQTTSubscriptionCompletionBlock)(BOOL, NSError * _Nullable, NSArray * _Nonnull);
    //delegate void MQTTSubscriptionCompletionBlock(bool completed, [NullAllowed] NSError error, NSArray grantedQos);

    //// typedef void (^MQTTPublishingCompletionBlock)(BOOL, NSError * _Nullable, int);
    //delegate void MQTTPublishingCompletionBlock(bool completed, [NullAllowed] NSError error, int mid);

    //// typedef void (^MQTTMessageHandler)(MASMQTTMessage * _Nonnull);
    //delegate void MQTTMessageHandler(MASMQTTMessage message);

    //// typedef void (^MQTTDisconnectionHandler)(NSUInteger);
    //delegate void MQTTDisconnectionHandler(nuint code);

    // @interface MASMQTTMessage : NSObject <NSCoding>
    //[BaseType(typeof(NSObject))]
    //interface MASMQTTMessage : INSCoding
    //{
    //    // @property (readonly, assign) unsigned short mid;
    //    [Export("mid")]
    //    ushort Mid { get; }

    //    // @property (readonly, copy) NSString * _Nonnull topic;
    //    [Export("topic")]
    //    string Topic { get; }

    //    // @property (readonly, copy) NSData * _Nonnull payload;
    //    [Export("payload", ArgumentSemantic.Copy)]
    //    NSData Payload { get; }

    //    // @property (readonly, assign) MQTTQualityOfService qos;
    //    [Export("qos", ArgumentSemantic.Assign)]
    //    MQTTQualityOfService Qos { get; }

    //    // @property (readonly, assign) BOOL retained;
    //    [Export("retained")]
    //    bool Retained { get; }

    //    // -(NSString * _Nonnull)payloadString;
    //    [Export("payloadString")]
    //    //[Verify(MethodToProperty)]
    //    string PayloadString { get; }

    //    // -(UIImage * _Nonnull)payloadImage;
    //    [Export("payloadImage")]
    //    //[Verify(MethodToProperty)]
    //    UIImage PayloadImage { get; }

    //    // -(id _Nonnull)initWithTopic:(NSString * _Nonnull)topic payload:(NSData * _Nonnull)payload qos:(MQTTQualityOfService)qos retain:(BOOL)retained mid:(short)mid;
    //    [Export("initWithTopic:payload:qos:retain:mid:")]
    //    IntPtr Constructor(string topic, NSData payload, MQTTQualityOfService qos, bool retained, short mid);
    //}

    //// @protocol MASConnectaMessagingClientDelegate <NSObject>
    ////[Protocol, Model]
    //[BaseType(typeof(NSObject))]
    //[Model]
    //interface MASConnectaMessagingClientDelegate
    //{
    //    // @required -(void)onMessageReceived:(MASMQTTMessage * _Nonnull)message;
    //    [Abstract]
    //    [Export("onMessageReceived:")]
    //    void OnMessageReceived(MASMQTTMessage message);

    //    // @required -(void)onPublishMessage:(NSNumber * _Nonnull)messageId;
    //    [Abstract]
    //    [Export("onPublishMessage:")]
    //    void OnPublishMessage(NSNumber messageId);

    //    // @required -(void)onConnected:(MQTTConnectionReturnCode)rc;
    //    [Abstract]
    //    [Export("onConnected:")]
    //    void OnConnected(MQTTConnectionReturnCode rc);

    //    // @required -(void)onDisconnect:(MQTTConnectionReturnCode)rc;
    //    [Abstract]
    //    [Export("onDisconnect:")]
    //    void OnDisconnect(MQTTConnectionReturnCode rc);
    //}

    //// @interface MASMQTTClient : NSObject
    //[BaseType(typeof(NSObject))]
    //interface MASMQTTClient
    //{
    //    [Wrap("WeakDelegate")]
    //    [NullAllowed]
    //    MASConnectaMessagingClientDelegate Delegate { get; set; }

    //    // @property (nonatomic, weak) id<MASConnectaMessagingClientDelegate> _Nullable delegate;
    //    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    // @property (readonly, assign, nonatomic) BOOL connected;
    //    [Export("connected")]
    //    bool Connected { get; }

    //    // @property (copy, nonatomic) MQTTMessageHandler _Nonnull messageHandler;
    //    [Export("messageHandler", ArgumentSemantic.Copy)]
    //    MQTTMessageHandler MessageHandler { get; set; }

    //    // @property (copy, nonatomic) MQTTDisconnectionHandler _Nonnull disconnectionHandler;
    //    [Export("disconnectionHandler", ArgumentSemantic.Copy)]
    //    MQTTDisconnectionHandler DisconnectionHandler { get; set; }

    //    // @property (assign, nonatomic) BOOL debugMode;
    //    [Export("debugMode")]
    //    bool DebugMode { get; set; }

    //    // @property (readwrite, copy) NSString * _Nonnull clientID;
    //    [Export("clientID")]
    //    string ClientID { get; set; }

    //    // +(instancetype _Nonnull)sharedClient;
    //    [Static]
    //    [Export("sharedClient")]
    //    MASMQTTClient SharedClient();

    //    // -(MASMQTTClient * _Nonnull)initWithClientId:(NSString * _Nonnull)clientId cleanSession:(BOOL)cleanSession;
    //    [Export("initWithClientId:cleanSession:")]
    //    IntPtr Constructor(string clientId, bool cleanSession);

    //    // -(void)setUsername:(NSString * _Nonnull)username Password:(NSString * _Nonnull)password;
    //    [Export("setUsername:Password:")]
    //    void SetUsername(string username, string password);

    //    // -(void)clearWill;
    //    [Export("clearWill")]
    //    void ClearWill();

    //    // -(void)setMessageRetry:(NSUInteger)seconds;
    //    [Export("setMessageRetry:")]
    //    void SetMessageRetry(nuint seconds);

    //    // -(void)setWill:(NSString * _Nonnull)payload toTopic:(NSString * _Nonnull)willTopic withQos:(MQTTQualityOfService)willQos retain:(BOOL)retain;
    //    [Export("setWill:toTopic:withQos:retain:")]
    //    void SetWill(string payload, string willTopic, MQTTQualityOfService willQos, bool retain);

    //    // +(NSString * _Nonnull)version;
    //    [Static]
    //    [Export("version")]
    //    //[Verify(MethodToProperty)]
    //    string Version { get; }

    //    // -(void)connectToHost:(NSString * _Nonnull)hostName completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
    //    [Export("connectToHost:completionHandler:")]
    //    void ConnectToHost(string hostName, Action<MQTTConnectionReturnCode> completionHandler);

    //    // -(void)connectToHost:(NSString * _Nonnull)hostName withTLS:(BOOL)tls completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
    //    [Export("connectToHost:withTLS:completionHandler:")]
    //    void ConnectToHost(string hostName, bool tls, Action<MQTTConnectionReturnCode> completionHandler);

    //    // -(void)connectWithHost:(NSString * _Nonnull)hostName withPort:(int)port enableTLS:(BOOL)tls completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
    //    [Export("connectWithHost:withPort:enableTLS:completionHandler:")]
    //    void ConnectWithHost(string hostName, int port, bool tls, Action<MQTTConnectionReturnCode> completionHandler);

    //    // -(void)connectWithHost:(NSString * _Nonnull)hostName withPort:(int)port enableTLS:(BOOL)tls usingSSLCACert:(NSString * _Nonnull)certFile completionHandler:(void (^ _Nonnull)(MQTTConnectionReturnCode))completionHandler;
    //    [Export("connectWithHost:withPort:enableTLS:usingSSLCACert:completionHandler:")]
    //    void ConnectWithHost(string hostName, int port, bool tls, string certFile, Action<MQTTConnectionReturnCode> completionHandler);

    //    // -(void)disconnectWithCompletionHandler:(MQTTDisconnectionHandler _Nonnull)completionHandler;
    //    [Export("disconnectWithCompletionHandler:")]
    //    void DisconnectWithCompletionHandler(MQTTDisconnectionHandler completionHandler);

    //    // -(void)reconnect;
    //    [Export("reconnect")]
    //    void Reconnect();

    //    // -(void)publishString:(NSString * _Nonnull)payload toTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos retain:(BOOL)retain completionHandler:(void (^ _Nonnull)(int))completionHandler __attribute__((deprecated("Use the new publishString:toTopic:withQoS:retain:completion method instead.")));
    //    [Export("publishString:toTopic:withQos:retain:completionHandler:")]
    //    void PublishString(string payload, string topic, MQTTQualityOfService qos, bool retain, Action<int> completionHandler);

    //    // -(void)publishString:(NSString * _Nonnull)payload toTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos retain:(BOOL)retain completion:(MQTTPublishingCompletionBlock _Nullable)completion;
    //    [Export("publishString:toTopic:withQos:retain:completion:")]
    //    void PublishString(string payload, string topic, MQTTQualityOfService qos, bool retain, [NullAllowed] MQTTPublishingCompletionBlock completion);

    //    // -(void)subscribeToTopic:(NSString * _Nonnull)topic withCompletionHandler:(MQTTSubscriptionCompletionHandler _Nonnull)completionHandler __attribute__((deprecated("Use the new subscribeToTopic:withCompletion method instead.")));
    //    [Export("subscribeToTopic:withCompletionHandler:")]
    //    void SubscribeToTopic(string topic, MQTTSubscriptionCompletionHandler completionHandler);

    //    // -(void)subscribeToTopic:(NSString * _Nonnull)topic withCompletion:(MQTTSubscriptionCompletionBlock _Nullable)completion;
    //    [Export("subscribeToTopic:withCompletion:")]
    //    void SubscribeToTopic(string topic, [NullAllowed] MQTTSubscriptionCompletionBlock completion);

    //    // -(void)subscribeToTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos completionHandler:(MQTTSubscriptionCompletionHandler _Nonnull)completionHandler __attribute__((deprecated("Use the new subscribeToTopic:withQos:completion method instead.")));
    //    [Export("subscribeToTopic:withQos:completionHandler:")]
    //    void SubscribeToTopic(string topic, MQTTQualityOfService qos, MQTTSubscriptionCompletionHandler completionHandler);

    //    // -(void)subscribeToTopic:(NSString * _Nonnull)topic withQos:(MQTTQualityOfService)qos completion:(MQTTSubscriptionCompletionBlock _Nullable)completion;
    //    [Export("subscribeToTopic:withQos:completion:")]
    //    void SubscribeToTopic(string topic, MQTTQualityOfService qos, [NullAllowed] MQTTSubscriptionCompletionBlock completion);

    //    // -(void)unsubscribeFromTopic:(NSString * _Nonnull)topic withCompletionHandler:(MQTTCompletionErrorBlock _Nullable)completionHandler;
    //    [Export("unsubscribeFromTopic:withCompletionHandler:")]
    //    void UnsubscribeFromTopic(string topic, [NullAllowed] MQTTCompletionErrorBlock completionHandler);
    //}

    //// @interface MASAuthenticationProvider : MASObject
    //[BaseType(typeof(MASObject))]
    //interface MASAuthenticationProvider
    //{
    //    // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
    //    [Export("identifier", ArgumentSemantic.Copy)]
    //    string Identifier { get; }

    //    // @property (readonly, copy, nonatomic) NSURL * _Nonnull authenticationUrl;
    //    [Export("authenticationUrl", ArgumentSemantic.Copy)]
    //    NSUrl AuthenticationUrl { get; }

    //    // @property (readonly, copy, nonatomic) NSUrl * _Nullable pollUrl;
    //    [NullAllowed, Export("pollUrl", ArgumentSemantic.Copy)]
    //    NSUrl PollUrl { get; }

    //    // -(id)isEnterprise;
    //    [Export("isEnterprise")]
    //    //[Verify(MethodToProperty)]
    //    NSObject IsEnterprise { get; }

    //    // -(id)isFacebook;
    //    [Export("isFacebook")]
    //    //[Verify(MethodToProperty)]
    //    NSObject IsFacebook { get; }

    //    // -(id)isGoogle;
    //    [Export("isGoogle")]
    //    //[Verify(MethodToProperty)]
    //    NSObject IsGoogle { get; }

    //    // -(id)isLinkedIn;
    //    [Export("isLinkedIn")]
    //    //[Verify(MethodToProperty)]
    //    NSObject IsLinkedIn { get; }

    //    // -(id)isQrCode;
    //    [Export("isQrCode")]
    //    //[Verify(MethodToProperty)]
    //    NSObject IsQrCode { get; }

    //    // -(id)isSalesforce;
    //    [Export("isSalesforce")]
    //    //[Verify(MethodToProperty)]
    //    NSObject IsSalesforce { get; }
    //}

    //// @interface MASAuthenticationProviders : MASObject
    //[BaseType(typeof(MASObject))]
    //interface MASAuthenticationProviders
    //{
    //    // @property (readonly, copy, nonatomic) NSArray * _Nullable providers;
    //    [NullAllowed, Export("providers", ArgumentSemantic.Copy)]
    //    //[Verify(StronglyTypedNSArray)]
    //    NSArray Providers { get; }

    //    // @property (readonly, copy, nonatomic) NSString * _Nullable idp;
    //    [NullAllowed, Export("idp")]
    //    string Idp { get; }

    //    // +(MASAuthenticationProviders * _Nullable)currentProviders;
    //    [Static]
    //    [NullAllowed, Export("currentProviders")]
    //    //[Verify(MethodToProperty)]
    //    MASAuthenticationProviders CurrentProviders { get; }

    //    // +(void)retrieveAuthenticationProvidersWithCompletion:(MASObjectResponseErrorBlock _Nullable)completion;
    //    [Static]
    //    [Export("retrieveAuthenticationProvidersWithCompletion:")]
    //    void RetrieveAuthenticationProvidersWithCompletion([NullAllowed] MASObjectResponseErrorBlock completion);

    //    // -(MASAuthenticationProvider * _Nullable)retrieveAuthenticationProviderForProximityLogin;
    //    [NullAllowed, Export("retrieveAuthenticationProviderForProximityLogin")]
    //    //[Verify(MethodToProperty)]
    //    MASAuthenticationProvider RetrieveAuthenticationProviderForProximityLogin { get; }
    //}

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
        NSArray<NSString> GatewayCertificates { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable trustedCertPinnedPublickKeyHashes;
        [NullAllowed, Export("trustedCertPinnedPublickKeyHashes", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSArray TrustedCertPinnedPublickKeyHashes { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable gatewayCertificatesAsDERData;
        [NullAllowed, Export("gatewayCertificatesAsDERData", ArgumentSemantic.Copy)]
        NSArray<NSString> GatewayCertificatesAsDERData { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable gatewayCertificatesAsPEMData;
        [NullAllowed, Export("gatewayCertificatesAsPEMData", ArgumentSemantic.Copy)]
        NSArray<NSString> GatewayCertificatesAsPEMData { get; }

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
        NSArray SecurityConfigurations { get; }

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
        //[Static]
        //[Export("setSecurityConfiguration:")]
        //void SetSecurityConfiguration(MASSecurityConfiguration securityConfiguration);
    }

    // @interface MASDevice : MASObject
    [BaseType(typeof(MASObject))]
    interface MASDevice
    {
        // @property (readonly, assign, nonatomic) BOOL isRegistered;
        [Export("isRegistered")]
        bool IsRegistered { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable status;
        [NullAllowed, Export("status")]
        string Status { get; }

        // @property (assign) BOOL isBeingAuthorized;
        [Export("isBeingAuthorized")]
        bool IsBeingAuthorized { get; set; }

        //// +(id<MASProximityLoginDelegate> _Nullable)proximityLoginDelegate;
        //// +(void)setProximityLoginDelegate:(id<MASProximityLoginDelegate> _Nonnull)delegate;
        //[Static]
        //[NullAllowed, Export("proximityLoginDelegate")]
        //MASProximityLoginDelegate ProximityLoginDelegate { get; set; }

        // +(MASDevice * _Nullable)currentDevice;
        [Static]
        [Export("currentDevice")]
        [return: NullAllowed]
        MASDevice CurrentDevice();

        // -(void)deregisterWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async(MethodName = "DeregisterAsync")]
        [Export("deregisterWithCompletion:")]
        void DeregisterWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)resetLocally;
        [Export("resetLocally")]
        void ResetLocally();

        //// -(void)startAsBluetoothPeripheral;
        //[Export("startAsBluetoothPeripheral")]
        //void StartAsBluetoothPeripheral();

        //// -(void)stopAsBluetoothPeripheral;
        //[Export("stopAsBluetoothPeripheral")]
        //void StopAsBluetoothPeripheral();

        //// -(void)startAsBluetoothCentral;
        //[Export("startAsBluetoothCentral")]
        //void StartAsBluetoothCentral();

        //// -(void)startAsBluetoothCentralWithAuthenticationProvider:(MASAuthenticationProvider * _Nonnull)provider;
        //[Export("startAsBluetoothCentralWithAuthenticationProvider:")]
        //void StartAsBluetoothCentralWithAuthenticationProvider(MASAuthenticationProvider provider);

        //// -(void)stopAsBluetoothCentral;
        //[Export("stopAsBluetoothCentral")]
        //void StopAsBluetoothCentral();
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

    //// @interface MASGroup : MASObject
    //[BaseType(typeof(MASObject))]
    //interface MASGroup
    //{
    //    // @property (readwrite, copy, nonatomic) NSString * _Nonnull groupName;
    //    [Export("groupName")]
    //    string GroupName { get; set; }

    //    // @property (readwrite, copy, nonatomic) NSString * _Nullable owner;
    //    [NullAllowed, Export("owner")]
    //    string Owner { get; set; }

    //    // @property (readwrite, copy, nonatomic) NSArray * _Nullable members;
    //    [NullAllowed, Export("members", ArgumentSemantic.Copy)]
    //    //[Verify(StronglyTypedNSArray)]
    //    NSArray Members { get; set; }

    //    // -(instancetype _Nullable)initWithInfo:(NSDictionary * _Nonnull)info;
    //    [Export("initWithInfo:")]
    //    IntPtr Constructor(NSDictionary info);

    //    // +(MASGroup * _Nullable)group;
    //    [Static]
    //    [NullAllowed, Export("group")]
    //    //[Verify(MethodToProperty)]
    //    MASGroup Group { get; }
    //}

    //// @interface MASProximityLogin : MASObject
    //[BaseType(typeof(MASObject))]
    //interface MASProximityLogin
    //{
    //}

    //// @interface MASProximityLoginQRCode : MASProximityLogin
    //[BaseType(typeof(MASProximityLogin))]
    //interface MASProximityLoginQRCode
    //{
    //    // @property (readonly, assign, nonatomic) NSNumber * _Nonnull pollingInterval;
    //    [Export("pollingInterval", ArgumentSemantic.Assign)]
    //    NSNumber PollingInterval { get; }

    //    // @property (readonly, assign, nonatomic) NSNumber * _Nonnull pollingDelay;
    //    [Export("pollingDelay", ArgumentSemantic.Assign)]
    //    NSNumber PollingDelay { get; }

    //    // @property (readonly, assign, nonatomic) NSNumber * _Nonnull pollingLimit;
    //    [Export("pollingLimit", ArgumentSemantic.Assign)]
    //    NSNumber PollingLimit { get; }

    //    // @property (readonly, assign, nonatomic) int currentPollingCounter;
    //    [Export("currentPollingCounter")]
    //    int CurrentPollingCounter { get; }

    //    // @property (readonly, assign, nonatomic) BOOL isPolling;
    //    [Export("isPolling")]
    //    bool IsPolling { get; }

    //    // @property (readonly, copy, nonatomic) NSString * _Nonnull authenticationUrl;
    //    [Export("authenticationUrl")]
    //    string AuthenticationUrl { get; }

    //    // @property (readonly, copy, nonatomic) NSString * _Nonnull pollUrl;
    //    [Export("pollUrl")]
    //    string PollUrl { get; }

    //    // -(instancetype _Nullable)initWithAuthenticationProvider:(MASAuthenticationProvider * _Nonnull)provider initialDelay:(NSNumber * _Nonnull)initDelay pollingInterval:(NSNumber * _Nonnull)pollingInterval pollingLimit:(NSNumber * _Nonnull)pollingLimit;
    //    [Export("initWithAuthenticationProvider:initialDelay:pollingInterval:pollingLimit:")]
    //    IntPtr Constructor(MASAuthenticationProvider provider, NSNumber initDelay, NSNumber pollingInterval, NSNumber pollingLimit);

    //    // -(instancetype _Nullable)initWithAuthenticationProvider:(MASAuthenticationProvider * _Nonnull)provider;
    //    [Export("initWithAuthenticationProvider:")]
    //    IntPtr Constructor(MASAuthenticationProvider provider);

    //    // -(UIImage * _Nullable)startDisplayingQRCodeImageForProximityLogin;
    //    [NullAllowed, Export("startDisplayingQRCodeImageForProximityLogin")]
    //    //[Verify(MethodToProperty)]
    //    //UIImage StartDisplayingQRCodeImageForProximityLogin { get; }
    //    UIImage StartDisplayingQRCodeImageForProximityLogin();

    //    // -(void)stopDisplayingQRCodeImageForProximityLogin;
    //    [Export("stopDisplayingQRCodeImageForProximityLogin")]
    //    void StopDisplayingQRCodeImageForProximityLogin();

    //    // +(void)authorizeAuthenticateUrl:(NSString * _Nonnull)authenticateUrl completion:(MASCompletionErrorBlock _Nullable)completion;
    //    [Static]
    //    [Export("authorizeAuthenticateUrl:completion:")]
    //    void AuthorizeAuthenticateUrl(string authenticateUrl, [NullAllowed] MASCompletionErrorBlock completion);
    //}

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

    //// @protocol MASSocialLoginDelegate <NSObject>
    ////[Protocol, Model]
    //[BaseType(typeof(NSObject))]
    //[Model]
    //interface MASSocialLoginDelegate
    //{
    //    // @required -(void)didReceiveAuthorizationCode:(NSString *)code __attribute__((deprecated("")));
    //    [Abstract]
    //    [Export("didReceiveAuthorizationCode:")]
    //    void DidReceiveAuthorizationCode(string code);

    //    // @optional -(void)didReceiveError:(NSError *)error __attribute__((deprecated("")));
    //    [Export("didReceiveError:")]
    //    void DidReceiveError(NSError error);

    //    // @optional -(void)didStartLoadingWebView __attribute__((deprecated("")));
    //    [Export("didStartLoadingWebView")]
    //    void DidStartLoadingWebView();

    //    // @optional -(void)didStopLoadingWebView __attribute__((deprecated("")));
    //    [Export("didStopLoadingWebView")]
    //    void DidStopLoadingWebView();
    //}

    //// @interface MASSocialLogin : MASObject
    //[BaseType(typeof(MASObject))]
    //interface MASSocialLogin
    //{
    //    // @property (nonatomic, strong) MASAuthenticationProvider * provider __attribute__((deprecated("")));
    //    [Export("provider", ArgumentSemantic.Strong)]
    //    MASAuthenticationProvider Provider { get; set; }

    //    [Wrap("WeakDelegate")]
    //    MASSocialLoginDelegate Delegate { get; set; }

    //    // @property (nonatomic, weak) id<MASSocialLoginDelegate> delegate __attribute__((deprecated("")));
    //    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    // -(instancetype)initWithAuthenticationProvider:(MASAuthenticationProvider *)provider webView:(WKWebView *)webView __attribute__((deprecated("")));
    //    [Export("initWithAuthenticationProvider:webView:")]
    //    IntPtr Constructor(MASAuthenticationProvider provider, WKWebView webView);
    //}

    // @interface MASUser : MASObject
    [BaseType(typeof(MASObject))]
    interface MASUser
    {
        // @property (readonly, assign, nonatomic) BOOL isCurrentUser;
        [Export("isCurrentUser")]
        bool IsCurrentUser { get; }

        // @property (readonly, assign, nonatomic) BOOL isAuthenticated;
        [Export("isAuthenticated")]
        bool IsAuthenticated { get; }

        // @property (readonly, assign, nonatomic) BOOL isSessionLocked;
        [Export("isSessionLocked")]
        bool IsSessionLocked { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull userName;
        [Export("userName")]
        string UserName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable familyName;
        [NullAllowed, Export("familyName")]
        string FamilyName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable givenName;
        [NullAllowed, Export("givenName")]
        string GivenName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable formattedName;
        [NullAllowed, Export("formattedName")]
        string FormattedName { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable emailAddresses;
        [NullAllowed, Export("emailAddresses", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> EmailAddresses { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable phoneNumbers;
        [NullAllowed, Export("phoneNumbers", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> PhoneNumbers { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable addresses;
        [NullAllowed, Export("addresses", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Addresses { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable photos;
        [NullAllowed, Export("photos", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Photos { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable groups;
        [NullAllowed, Export("groups", ArgumentSemantic.Copy)]
        NSArray<NSString> Groups { get; }

        // @property (readonly, assign, nonatomic) BOOL active;
        [Export("active")]
        bool Active { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable accessToken;
        [NullAllowed, Export("accessToken")]
        string AccessToken { get; }

        // +(MASUser * _Nullable)currentUser;
        [Static]
        [NullAllowed, Export("currentUser")]
        MASUser CurrentUser { get; }

        // +(NSString * _Nullable)authCredentialsType;
        [Static]
        [NullAllowed, Export("authCredentialsType")]
        string AuthCredentialsType { get; }

        // -(void)lockSessionWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async(MethodName = "LockSessionAsync")]
        [Export("lockSessionWithCompletion:")]
        void LockSessionWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)unlockSessionWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async(MethodName = "UnlockSessionAsync")]
        [Export("unlockSessionWithCompletion:")]
        void UnlockSessionWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)unlockSessionWithUserOperationPromptMessage:(NSString * _Nonnull)userOperationPrompt completion:(MASCompletionErrorBlock _Nullable)completion;
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("unlockSessionWithUserOperationPromptMessage:completion:")]
        void UnlockSessionWithUserOperationPromptMessage(string userOperationPrompt, [NullAllowed] MASCompletionErrorBlock completion);

        // -(void)removeSessionLock;
        [Export("removeSessionLock")]
        void RemoveSessionLock();

        // +(void)loginWithUserName:(NSString * _Nonnull)userName password:(NSString * _Nonnull)password completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("loginWithUserName:password:completion:")]
        void LoginWithUserName(string userName, string password, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)loginWithAuthorizationCode:(NSString * _Nonnull)authorizationCode completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("loginWithAuthorizationCode:completion:")]
        void LoginWithAuthorizationCode(string authorizationCode, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)loginWithIdToken:(NSString * _Nonnull)idToken tokenType:(NSString * _Nonnull)tokenType completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("loginWithIdToken:tokenType:completion:")]
        void LoginWithIdToken(string idToken, string tokenType, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)loginWithAuthCredentials:(MASAuthCredentials * _Nonnull)authCredentials completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("loginWithAuthCredentials:completion:")]
        void LoginWithAuthCredentials(MASAuthCredentials authCredentials, [NullAllowed] MASCompletionErrorBlock completion);

        //// +(void)initializeBrowserBasedAuthenticationWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        //[Static]
        //[Export("initializeBrowserBasedAuthenticationWithCompletion:")]
        //void InitializeBrowserBasedAuthenticationWithCompletion([NullAllowed] MASCompletionErrorBlock completion);

        // -(void)requestUserInfoWithCompletion:(MASUserResponseErrorBlock _Nullable)completion;
        //[Async(ResultTypeName = "MASUserResponseErrorResult")]
        [Async(MethodName = "RequestUserInfoAsync")]
        [Export("requestUserInfoWithCompletion:")]
        void RequestUserInfoWithCompletion([NullAllowed] MASUserResponseErrorBlock completion);

        // -(void)logoutWithCompletion:(MASCompletionErrorBlock _Nullable)completion;
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async(MethodName = "LogoutAsync")]
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

    //// @interface MASClaims : MASObject
    //[BaseType(typeof(MASObject))]
    //interface MASClaims
    //{
    //    // @property (readwrite, nonatomic, strong) NSString * _Nullable iss;
    //    [NullAllowed, Export("iss", ArgumentSemantic.Strong)]
    //    string Iss { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSString * _Nullable aud;
    //    [NullAllowed, Export("aud", ArgumentSemantic.Strong)]
    //    string Aud { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSString * _Nullable sub;
    //    [NullAllowed, Export("sub", ArgumentSemantic.Strong)]
    //    string Sub { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSDate * _Nullable exp;
    //    [NullAllowed, Export("exp", ArgumentSemantic.Strong)]
    //    NSDate Exp { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSDate * _Nullable iat;
    //    [NullAllowed, Export("iat", ArgumentSemantic.Strong)]
    //    NSDate Iat { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSDate * _Nullable nbf;
    //    [NullAllowed, Export("nbf", ArgumentSemantic.Strong)]
    //    NSDate Nbf { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSString * _Nullable jti;
    //    [NullAllowed, Export("jti", ArgumentSemantic.Strong)]
    //    string Jti { get; set; }

    //    // @property (readwrite, nonatomic, strong) id _Nullable content;
    //    [NullAllowed, Export("content", ArgumentSemantic.Strong)]
    //    NSObject Content { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSString * _Nullable contentType;
    //    [NullAllowed, Export("contentType", ArgumentSemantic.Strong)]
    //    string ContentType { get; set; }

    //    // @property (readonly, nonatomic, strong) NSMutableDictionary * _Nullable customClaims;
    //    [NullAllowed, Export("customClaims", ArgumentSemantic.Strong)]
    //    NSMutableDictionary CustomClaims { get; }

    //    // -(void)setValue:(id _Nonnull)value forClaimKey:(NSString * _Nonnull)claimKey error:(NSError * _Nullable * _Nullable)error;
    //    [Export("setValue:forClaimKey:error:")]
    //    void SetValue(NSObject value, string claimKey, [NullAllowed] out NSError error);

    //    // +(MASClaims * _Nullable)claims;
    //    [Static]
    //    [NullAllowed, Export("claims")]
    //    //[Verify(MethodToProperty)]
    //    MASClaims Claims { get; }
    //}

    // @interface MASRequestBuilder : MASObject
    [BaseType(typeof(MASObject))]
    interface MASRequestBuilder
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull httpMethod;
        [Export("httpMethod", ArgumentSemantic.Strong)]
        string HttpMethod { get; }

        // @property (assign) BOOL isPublic;
        [Export("isPublic")]
        bool IsPublic { get; set; }

        //// @property (readonly, assign) BOOL sign;
        //[Export("sign")]
        //bool Sign { get; }

        // @property (nonatomic, strong) NSString * _Nullable endPoint;
        [NullAllowed, Export("endPoint", ArgumentSemantic.Strong)]
        string EndPoint { get; set; }

        //// @property (readonly, nonatomic, strong) MASClaims * _Nullable claims;
        //[NullAllowed, Export("claims", ArgumentSemantic.Strong)]
        //MASClaims Claims { get; }

        // @property (readonly, nonatomic, strong) NSData * _Nullable privateKey;
        [NullAllowed, Export("privateKey", ArgumentSemantic.Strong)]
        NSData PrivateKey { get; }

        // @property (nonatomic, strong) NSDictionary * _Nullable header;
        [NullAllowed, Export("header", ArgumentSemantic.Strong)]
        NSDictionary Header { get; set; }

        // @property (nonatomic, strong) NSDictionary * _Nullable body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        NSDictionary Body { get; set; }

        // @property (nonatomic, strong) NSDictionary * _Nullable query;
        [NullAllowed, Export("query", ArgumentSemantic.Strong)]
        NSDictionary Query { get; set; }

        // @property (assign) MASRequestResponseType requestType;
        [Export("requestType", ArgumentSemantic.Assign)]
        MASRequestResponseType RequestType { get; set; }

        // @property (assign) MASRequestResponseType responseType;
        [Export("responseType", ArgumentSemantic.Assign)]
        MASRequestResponseType ResponseType { get; set; }

        // -(instancetype _Nonnull)initWithHTTPMethod:(NSString * _Nonnull)method __attribute__((objc_designated_initializer));
        [Export("initWithHTTPMethod:")]
        [DesignatedInitializer]
        IntPtr Constructor(string method);

        // -(MASRequest * _Nullable)build;
        [NullAllowed, Export("build")]

        //MASRequest Build { get; }
        MASRequest Build();

        //// -(void)setSignWithError:(NSError * _Nullable * _Nullable)error;
        //[Export("setSignWithError:")]
        //void SetSignWithError([NullAllowed] out NSError error);

        //// -(void)setSignWithClaims:(MASClaims * _Nonnull)claims error:(NSError * _Nullable * _Nullable)error;
        //[Export("setSignWithClaims:error:")]
        //void SetSignWithClaims(MASClaims claims, [NullAllowed] out NSError error);

        //// -(void)setSignWithClaims:(MASClaims * _Nonnull)claims privateKey:(NSData * _Nonnull)privateKey error:(NSError * _Nullable * _Nullable)error;
        //[Export("setSignWithClaims:privateKey:error:")]
        //void SetSignWithClaims(MASClaims claims, NSData privateKey, [NullAllowed] out NSError error);
    }

    // @interface MASRequest : MASObject
    [BaseType(typeof(MASObject))]
    interface MASRequest
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull httpMethod;
        [Export("httpMethod", ArgumentSemantic.Strong)]
        string HttpMethod { get; }

        // @property (readonly, assign) BOOL isPublic;
        [Export("isPublic")]
        bool IsPublic { get; }

        //// @property (readonly, assign) BOOL sign;
        //[Export("sign")]
        //bool Sign { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable endPoint;
        [NullAllowed, Export("endPoint", ArgumentSemantic.Strong)]
        string EndPoint { get; }

        // @property (readonly, nonatomic, strong) NSData * _Nullable privateKey;
        [NullAllowed, Export("privateKey", ArgumentSemantic.Strong)]
        NSData PrivateKey { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * _Nullable header;
        [NullAllowed, Export("header", ArgumentSemantic.Strong)]
        NSDictionary Header { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * _Nullable body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        NSDictionary Body { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * _Nullable query;
        [NullAllowed, Export("query", ArgumentSemantic.Strong)]
        NSDictionary Query { get; }

        // @property (readonly, assign) MASRequestResponseType requestType;
        [Export("requestType", ArgumentSemantic.Assign)]
        MASRequestResponseType RequestType { get; }

        // @property (readonly, assign) MASRequestResponseType responseType;
        [Export("responseType", ArgumentSemantic.Assign)]
        MASRequestResponseType ResponseType { get; }

        // +(instancetype _Nullable)deleteFrom:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        [Static]
        [Export("deleteFrom:")]
        [return: NullAllowed]
        MASRequest DeleteFrom(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)getFrom:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        [Static]
        [Export("getFrom:")]
        [return: NullAllowed]
        MASRequest GetFrom(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)patchTo:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        [Static]
        [Export("patchTo:")]
        [return: NullAllowed]
        MASRequest PatchTo(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)postTo:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        [Static]
        [Export("postTo:")]
        [return: NullAllowed]
        MASRequest PostTo(Action<MASRequestBuilder> block);

        // +(instancetype _Nullable)putTo:(void (^ _Nonnull)(MASRequestBuilder * _Nonnull))block;
        [Static]
        [Export("putTo:")]
        [return: NullAllowed]
        MASRequest PutTo(Action<MASRequestBuilder> block);
    }

    // @interface MAS : NSObject
    [BaseType(typeof(NSObject))]
    interface MAS
    {
        // +(void)setConfigurationFileName:(NSString * _Nonnull)fileName;
        [Static]
        [Export("setConfigurationFileName:")]
        void SetConfigurationFileName(string fileName);

        // +(MASGrantFlow)grantFlow;
        // +(void)setGrantFlow:(MASGrantFlow)grantFlow;
        [Static]
        [Export("grantFlow")]
        //[Verify(MethodToProperty)]
        MASGrantFlow GrantFlow { get; set; }

        //// +(void)enablePKCE:(BOOL)enable;
        //[Static]
        //[Export("enablePKCE:")]
        //void EnablePKCE(bool enable);

        //// +(BOOL)isPKCEEnabled;
        //[Static]
        //[Export("isPKCEEnabled")]
        ////[Verify(MethodToProperty)]
        //bool IsPKCEEnabled { get; }

        // +(void)setUserAuthCredentials:(MASUserAuthCredentialsBlock _Nullable)userAuthCredentialsBlock;
        [Static]
        [Export("setUserAuthCredentials:")]
        void SetUserAuthCredentials([NullAllowed] MASUserAuthCredentialsBlock userAuthCredentialsBlock);

        //// +(void)setOTPChannelSelectionBlock:(MASOTPChannelSelectionBlock _Nullable)OTPChannelSelector;
        //[Static]
        //[Export("setOTPChannelSelectionBlock:")]
        //void SetOTPChannelSelectionBlock([NullAllowed] MASOTPChannelSelectionBlock OTPChannelSelector);

        //// +(void)setOTPCredentialsBlock:(MASOTPCredentialsBlock _Nullable)oneTimePassword;
        //[Static]
        //[Export("setOTPCredentialsBlock:")]
        //void SetOTPCredentialsBlock([NullAllowed] MASOTPCredentialsBlock oneTimePassword);

        //// +(void)enableBrowserBasedAuthentication:(BOOL)enable;
        //[Static]
        //[Export("enableBrowserBasedAuthentication:")]
        //void EnableBrowserBasedAuthentication(bool enable);

        // +(void)setGatewayMonitor:(MASGatewayMonitorStatusBlock _Nullable)monitor;
        [Static]
        [Export("setGatewayMonitor:")]
        void SetGatewayMonitor([NullAllowed] MASGatewayMonitorStatusBlock monitor);

        // +(MASState)MASState;
        [Static]
        [Export("MASState")]
         MASState MASState { get; }

        // +(void)setGatewayNetworkActivityLogging:(BOOL)enabled;
        [Static]
        [Export("setGatewayNetworkActivityLogging:")]
        void SetGatewayNetworkActivityLogging(bool enabled);

        // +(void)setKeychainSynchronizable:(BOOL)enabled;
        [Static]
        [Export("setKeychainSynchronizable:")]
        void SetKeychainSynchronizable(bool enabled);

        // +(BOOL)isKeychainSynchronizable;
        [Static]
        [Export("isKeychainSynchronizable")]
        bool IsKeychainSynchronizable { get; }

        // +(void)start:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("start:")]
        void Start([NullAllowed] MASCompletionErrorBlock completion);

        // +(void)startWithDefaultConfiguration:(BOOL)shouldUseDefault completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("startWithDefaultConfiguration:completion:")]
        void StartWithDefaultConfiguration(Boolean shouldUseDefault, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)startWithJSON:(NSDictionary * _Nonnull)jsonConfiguration completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("startWithJSON:completion:")]
        void StartWithJSON(NSDictionary jsonConfiguration, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)startWithURL:(NSURL * _Nullable)url completion:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("startWithURL:completion:")]
        void StartWithURL([NullAllowed] NSUrl url, [NullAllowed] MASCompletionErrorBlock completion);

        // +(void)stop:(MASCompletionErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASCompletionErrorResult")]
        [Async]
        [Export("stop:")]
        void Stop([NullAllowed] MASCompletionErrorBlock completion);

        // +(BOOL)gatewayIsReachable;
        [Static]
        [Export("gatewayIsReachable")]
        //[Verify(MethodToProperty)]
        bool GatewayIsReachable { get; }

        // +(NSString * _Nonnull)gatewayMonitoringStatusAsString;
        [Static]
        [Export("gatewayMonitoringStatusAsString")]
        //[Verify(MethodToProperty)]
        string GatewayMonitoringStatusAsString { get; }

        // +(void)deleteFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("deleteFrom:withParameters:andHeaders:completion:")]
        void DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)deleteFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("deleteFrom:withParameters:andHeaders:requestType:responseType:completion:")]
        void DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)deleteFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("deleteFrom:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void DeleteFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)getFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("getFrom:withParameters:andHeaders:completion:")]
        void GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)getFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("getFrom:withParameters:andHeaders:requestType:responseType:completion:")]
        void GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)getFrom:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("getFrom:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void GetFrom(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)patchTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("patchTo:withParameters:andHeaders:completion:")]
        void PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)patchTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("patchTo:withParameters:andHeaders:requestType:responseType:completion:")]
        void PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)patchTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("patchTo:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void PatchTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)postTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("postTo:withParameters:andHeaders:completion:")]
        void PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)postTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("postTo:withParameters:andHeaders:requestType:responseType:completion:")]
        void PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)postTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("postTo:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void PostTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)putTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("putTo:withParameters:andHeaders:completion:")]
        void PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)putTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("putTo:withParameters:andHeaders:requestType:responseType:completion:")]
        void PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)putTo:(NSString * _Nonnull)endPointPath withParameters:(NSDictionary * _Nullable)parameterInfo andHeaders:(NSDictionary * _Nullable)headerInfo requestType:(MASRequestResponseType)requestType responseType:(MASRequestResponseType)responseType isPublic:(BOOL)isPublic completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        //[Async(ResultTypeName = "MASResponseInfoErrorResult")]
        [Async]
        [Export("putTo:withParameters:andHeaders:requestType:responseType:isPublic:completion:")]
        void PutTo(string endPointPath, [NullAllowed] NSDictionary parameterInfo, [NullAllowed] NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, [NullAllowed] MASResponseInfoErrorBlock completion);

        // +(void)invoke:(MASRequest * _Nonnull)request completion:(MASResponseInfoErrorBlock _Nullable)completion;
        [Static]
        [Async(ResultTypeName = "MASResponseObjectErrorResult")]
        [Export("invoke:completion:")]
        void Invoke(MASRequest request, [NullAllowed] MASResponseObjectErrorBlock completion);

        //// +(NSString * _Nullable)signWithClaims:(MASClaims * _Nonnull)claims error:(NSError * _Nullable * _Nullable)error;
        //[Static]
        //[Export("signWithClaims:error:")]
        //[return: NullAllowed]
        //string SignWithClaims(MASClaims claims, [NullAllowed] out NSError error);

        //// +(NSString * _Nullable)signWithClaims:(MASClaims * _Nonnull)claims privateKey:(NSData * _Nonnull)privateKey error:(NSError * _Nullable * _Nullable)error;
        //[Static]
        //[Export("signWithClaims:privateKey:error:")]
        //[return: NullAllowed]
        //string SignWithClaims(MASClaims claims, NSData privateKey, [NullAllowed] out NSError error);
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

        //// @property (readonly, copy, nonatomic) NSString * _Nullable iconUrl;
        //[NullAllowed, Export("iconUrl")]
        //string IconUrl { get; }

        //// @property (readonly, copy, nonatomic) NSString * _Nullable authUrl;
        //[NullAllowed, Export("authUrl")]
        //string AuthUrl { get; }

        //// @property (readonly, copy, nonatomic) NSString * _Nullable nativeUrl;
        //[NullAllowed, Export("nativeUrl")]
        //string NativeUrl { get; }

        //// @property (readonly, copy, nonatomic) NSDictionary * _Nullable customProperties;
        //[NullAllowed, Export("customProperties", ArgumentSemantic.Copy)]
        //NSDictionary CustomProperties { get; }

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
        NSArray<NSString> Scope { get; }

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

        //[Wrap("WeakDelegate")]
        //[NullAllowed]
        //MASEnterpriseAppProtocol Delegate { get; set; }

        // @property id<MASEnterpriseAppProtocol> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // +(MASApplication * _Nullable)currentApplication;
        [Static]
        [NullAllowed, Export("currentApplication")]
        MASApplication CurrentApplication { get; }

        // -(void)retrieveEnterpriseApps:(MASObjectsResponseErrorBlock _Nullable)completion;
        //[Export("retrieveEnterpriseApps:")]
        //void RetrieveEnterpriseApps([NullAllowed] MASObjectsResponseErrorBlock completion);

        //// -(void)enterpriseIconWithImageView:(UIImageView * _Nonnull)imageView completion:(MASCompletionErrorBlock _Nullable)completion;
        //[Export("enterpriseIconWithImageView:completion:")]
        //void EnterpriseIconWithImageView(UIImageView imageView, [NullAllowed] MASCompletionErrorBlock completion);

        //// -(void)loadWebApp:(UIWebView * _Nonnull)webView completion:(MASCompletionErrorBlock _Nullable)completion;
        //[Export("loadWebApp:completion:")]
        //void LoadWebApp(UIWebView webView, [NullAllowed] MASCompletionErrorBlock completion);
    }

    //// @protocol MASEnterpriseAppProtocol <NSObject>
    ////[Protocol, Model]
    //[BaseType(typeof(NSObject))]
    //[Model]
    //interface MASEnterpriseAppProtocol
    //{
    //    // @required -(void)enterpriseWebApp:(MASApplication * _Nonnull)app;
    //    [Abstract]
    //    [Export("enterpriseWebApp:")]
    //    void EnterpriseWebApp(MASApplication app);

    //    // @required -(void)enterpriseApp:(MASApplication * _Nonnull)app didReceiveError:(NSError * _Nonnull)error;
    //    [Abstract]
    //    [Export("enterpriseApp:didReceiveError:")]
    //    void EnterpriseApp(MASApplication app, NSError error);
    //}

    // @interface MASAuthCredentials : MASObject
    [BaseType(typeof(MASObject))]
    interface MASAuthCredentials
    {
        // @property (nonatomic, strong, readonly, nonnull) NSString *credentialsType;
        [Export("credentialsType", ArgumentSemantic.Strong)]
        string CredentialsType { get; }

        // @property (nonatomic, strong, readonly, nonnull) NSString *csrUsername;
        [Export("csrUsername", ArgumentSemantic.Strong)]
        string CsrUsername { get; }

        // @property (nonatomic, strong, readonly, nonnull) NSString *registerEndpoint;
        [Export("registerEndpoint", ArgumentSemantic.Strong)]
        string RegisterEndpoint { get; }

        // @property (nonatomic, strong, readonly, nonnull) NSString *tokenEndpoint;
        [Export("tokenEndpoint", ArgumentSemantic.Strong)]
        string TokenEndpoint { get; }

        // @property (readonly, assign, nonatomic) BOOL canRegisterDevice;
        [Export("canRegisterDevice")]
        bool CanRegisterDevice { get; }

        // @property (nonatomic, assign, readonly) BOOL isReusable;
        [Export("isReusable")]
        bool IsReusable { get; }

        // -(void)clearCredentials;
        [Export("clearCredentials")]
        void ClearCredentials();

        // (instancetype _Nullable)initWithCredentialsType:(NSString * _Nonnull)credentialsType csrUsername:(NSString * _Nonnull)csrUsername canRegisterDevice:(BOOL)canRegisterDevice isReusable:(BOOL)isReusable;
        [Export("initWithCredentialsType:csrUsername:canRegisterDevice:isReusable:")]
        IntPtr Constructor(string credentialsType, string csrUsername, bool canRegisterDevice, bool isReusable);

        // - (instancetype _Nullable)initWithCredentialsType:(NSString * _Nonnull)credentialsType csrUsername:(NSString * _Nonnull)csrUsername canRegisterDevice:(BOOL)canRegisterDevice isReusable:(BOOL)isReusable registerEndpoint:(NSString * _Nonnull)registerEndpoint tokenEndpoint:(NSString * _Nonnull)tokenEndpoint;
        [Export("initWithCredentialsType:csrUsername:canRegisterDevice:isReusable:registerEndpoint:tokenEndpoint:")]
        IntPtr Constructor(string credentialsType, string csrUsername, bool canRegisterDevice, bool isReusable, string registerEndpoint, string tokenEndpoint);

        // -(id)getHeaders;
        [Export("getHeaders")]
        NSDictionary Headers { get; }

        // -(id)getParameters;
        [Export("getParameters")]
        NSDictionary Parameters { get; }
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