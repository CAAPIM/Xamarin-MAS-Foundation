// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using ObjCRuntime;

namespace MASFoundation
{
    /// 
    /// This API includes all features available in the native iOS SDK. Howerver, in this first realease only a subset of the features are available:
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

    //[Native]
    public enum MASAuthenticationStatus
    {
        NotLoggedIn = -1,
        LoginWithUser,
        LoginAnonymously
    }

    //[Native]
    public enum MASGrantFlow
    {
        Unknown = -1,
        ClientCredentials,
        Password,
        Count
    }

    //[Native]
    public enum MASRequestResponseType
    {
        Unknown = -1,
        Json,
        ScimJson,
        TextPlain,
        WwwFormUrlEncoded,
        Xml,
        FormData,
        Count
    }

    //[Native]
    public enum MASState
    {
        NotConfigured = -1,
        NotInitialized,
        DidLoad,
        WillStart,
        DidStart,
        WillStop,
        DidStop,
        IsBeingStopped
    }

    //[Native]
    public enum MASFileDirectoryType
    {
        Temporary = -1,
        ApplicationSupport,
        CachesDirectory,
        Documents,
        Library
    }

    //[Native]
    public enum MASFoundationErrorCode
    {
        Unknown = -1,
        InvalidNSURL = 100001,
        InvalidNSDictionary = 100002,
        InvalidUserLoginBlock = 100003,
        MASIsNotStarted = 100004,
        InvalidEnrollmentURL = 100005,
        FlowIsNotActive = 100101,
        FlowIsNotImplemented = 100102,
        FlowTypeUnsupported = 100103,
        ConfigurationLoadingFailedFileNotFound = 100201,
        ConfigurationLoadingFailedJsonSerialization = 100202,
        ConfigurationLoadingFailedJsonValidation = 100203,
        ConfigurationInvalidEndpoint = 100204,
        ConfigurationInvalidHostForSecurityConfiguration = 100211,
        ConfigurationInvalidPinningInfoForSecurityConfiguration = 100212,
        GeolocationIsInvalid = 100301,
        GeolocationIsMissing = 100302,
        GeolocationServicesAreUnauthorized = 100303,
        GeolocationIsNotConfigured = 100304,
        NetworkUnacceptableContentType = 100401,
        NetworkIsOffline = 100402,
        NetworkNotReachable = 100403,
        NetworkNotStarted = 100404,
        NetworkRequestTimedOut = 100405,
        NetworkSSLConnectionCannotBeMade = 100406,
        ResponseSerializationFailedToParseResponse = 100407,
        NetworkSSLAuthenticationChallengeFailure = 100408,
        ApplicationAlreadyRegistered = 110001,
        ApplicationInvalid = 110002,
        ApplicationNotRegistered = 110003,
        ApplicationInvalidMagIdentifer = 110004,
        ApplicationRedirectUriInvalid = 110005,
        DeviceAlreadyRegistered = 120001,
        DeviceAlreadyRegisteredWithDifferentFlow = 120002,
        DeviceCouldNotBeDeregistered = 120003,
        DeviceNotRegistered = 120004,
        DeviceNotLoggedIn = 120005,
        DeviceRecordIsNotValid = 120006,
        DeviceRegistrationAttemptedWithUnregisteredScope = 120007,
        DeviceRegistrationWithoutRequiredParameters = 120008,
        DeviceDoesNotSupportLocalAuthentication = 120009,
        DeviceInvalidAuthCredentialsForDeviceRegistration = 120010,
        InvalidAuthorization = 131001,
        UserAlreadyAuthenticated = 130001,
        UserBasicCredentialsNotValid = 130002,
        UserDoesNotExist = 130003,
        UserNotAuthenticated = 130004,
        LoginProcessCancel = 130005,
        UserSessionIsAlreadyLocked = 130006,
        UserSessionIsAlreadyUnlocked = 130007,
        UserSessionIsCurrentlyLocked = 130008,
        TokenInvalidIdToken = 130101,
        TokenIdTokenExpired = 130102,
        TokenIdTokenInvalidAud = 130103,
        TokenIdTokenInvalidAzp = 130104,
        TokenIdTokenInvalidSignature = 130105,
        TokenIdTokenNotExistForLockingUserSession = 130106,
        AccessTokenInvalid = 130201,
        AccessTokenDisabled = 130202,
        AccessTokenNotGrantedScope = 130203,
        EnterpriseBrowserWebAppInvalidURL = 140001,
        EnterpriseBrowserNativeAppDoesNotExist = 140002,
        EnterpriseBrowserNativeAppCannotOpen = 140003,
        EnterpriseBrowserAppDoesNotExist = 140004,
        InvalidOTPChannelSelectionBlock = 160101,
        InvalidOTPCredentialsBlock = 160102,
        InvalidOTPProvided = 160103,
        OTPNotProvided = 160104,
        OTPExpired = 160105,
        OTPRetryLimitExceeded = 160106,
        OTPRetryBarred = 160107,
        OTPChannelSelectionCancelled = 160201,
        OTPAuthenticationCancelled = 160202,
        JWTInvalidClaims = 170001,
        JWTUnexpectedClassType = 170002,
        JWTSerializationError = 170003,
        BBANotEnabled = 180000,
        SharedStorageNotNilKey = 180001,
		MultiFactorAuthenticationCancelled = 180002,
        MultiFactorAuthenticationInvalidRequest = 180003,
        Count = -999999
    }

    //[Native]
    public enum MASGatewayMonitoringStatus
    {
        Unknown = -1,
        NotReachable,
        ReachableViaWWAN,
        ReachableViaWiFi,
        Count
    }

	//[Native]
    public enum MASNetworkReachabilityStatus
    {
        Unknown = -1,
        NotReachable = 1,
        ReachableViaWWAN = 2,
        ReachableViaWiFi = 3,
        Initializing = 4
    }

    public enum MASSecuritySSLPinningMode
    {
        PublicKeyHash,
        Certificate,
        IntermediateCertifcate
    }

    ////[Native]
    //public enum MASBLEServiceState
    //{
    //    Unknown = -1,
    //    CentralStarted,
    //    CentralStopped,
    //    CentralDeviceDetected,
    //    CentralDeviceConnected,
    //    CentralDeviceDisconnected,
    //    CentralServiceDiscovered,
    //    CentralCharacteristicDiscovered,
    //    CentralCharacteristicWritten,
    //    CentralAuthorizationSucceeded,
    //    CentralAuthorizationFailed,
    //    PeripheralSubscribed,
    //    PeripheralUnsubscribed,
    //    PeripheralStarted,
    //    PeripheralStopped,
    //    PeripheralSessionAuthorized,
    //    PeripheralSessionNotified
    //}

    ////[Native]
    //public enum MASServiceLifecycleStatus
    //{
    //    Unknown = -1,
    //    Initialized,
    //    Loaded,
    //    WillStart,
    //    DidStart,
    //    WillStop,
    //    DidStop,
    //    StateCount
    //}

    ////[Native]
    //public enum MQTTConnectionReturnCode
    //{
    //    Accepted,
    //    RefusedUnacceptableProtocolVersion,
    //    RefusedIdentifierRejected,
    //    RefusedServerUnavailable,
    //    RefusedBadUserNameOrPassword,
    //    RefusedNotAuthorized
    //}

    ////[Native]
    //public enum MQTTQualityOfService
    //{
    //    AtMostOnce,
    //    AtLeastOnce,
    //    ExactlyOnce
    //}
}
