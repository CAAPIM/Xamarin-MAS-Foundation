// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using ObjCRuntime;

namespace MASFoundation
{
    //[Native]
    public enum MASAuthenticationStatus //: nint
    {
        NotLoggedIn = -1,
        LoginWithUser,
        LoginAnonymously
    }

    //[Native]
    public enum MASGrantFlow //: nint
    {
        Unknown = -1,
        ClientCredentials,
        Password,
        Count
    }

    //[Native]
    public enum MASRequestResponseType //: nint
    {
        Unknown = -1,
        Json,
        ScimJson,
        TextPlain,
        WwwFormUrlEncoded,
        Xml,
        Count
    }

    //[Native]
    public enum MASState //: nint
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
    public enum MASFileDirectoryType //: nint
    {
        Temporary = -1,
        ApplicationSupport,
        CachesDirectory,
        Documents,
        Library
    }

    //[Native]
    public enum MASFoundationErrorCode //: nint
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
        BLEUnknownState = 150001,
        BLEAuthorizationFailed = 150002,
        BLEAuthorizationPollingFailed = 150003,
        BLECentralDeviceNotFound = 150004,
        BLEDelegateNotDefined = 150005,
        BLEInvalidAuthenticationProvider = 150006,
        BLEPoweredOff = 150007,
        BLERestting = 150008,
        BLERSSINotInRange = 150009,
        BLEUnSupported = 150010,
        BLEUnauthorized = 150011,
        BLEUserDeclined = 150012,
        BLECentral = 150013,
        BLEPeripheral = 150014,
        BLEPeripheralServices = 150015,
        BLEPeripheralCharacteristics = 150016,
        ProximityLoginAuthorizationInProgress = 150101,
        ProximityLoginInvalidAuthenticationURL = 150102,
        QRCodeProximityLoginAuthorizationPollingFailed = 150103,
        ProximityLoginInvalidAuthorizeURL = 150104,
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
        Count = -999999
    }

    //[Native]
    public enum MASGatewayMonitoringStatus //: nint
    {
        Unknown = -1,
        NotReachable,
        ReachableViaWWAN,
        ReachableViaWiFi,
        Count
    }

    //[Native]
    public enum MASBLEServiceState //: nint
    {
        Unknown = -1,
        CentralStarted,
        CentralStopped,
        CentralDeviceDetected,
        CentralDeviceConnected,
        CentralDeviceDisconnected,
        CentralServiceDiscovered,
        CentralCharacteristicDiscovered,
        CentralCharacteristicWritten,
        CentralAuthorizationSucceeded,
        CentralAuthorizationFailed,
        PeripheralSubscribed,
        PeripheralUnsubscribed,
        PeripheralStarted,
        PeripheralStopped,
        PeripheralSessionAuthorized,
        PeripheralSessionNotified
    }

    //[Native]
    public enum MASServiceLifecycleStatus //: nint
    {
        Unknown = -1,
        Initialized,
        Loaded,
        WillStart,
        DidStart,
        WillStop,
        DidStop,
        StateCount
    }

    //[Native]
    public enum MQTTConnectionReturnCode //: nuint
    {
        Accepted,
        RefusedUnacceptableProtocolVersion,
        RefusedIdentifierRejected,
        RefusedServerUnavailable,
        RefusedBadUserNameOrPassword,
        RefusedNotAuthorized
    }

    //[Native]
    public enum MQTTQualityOfService //: nint
    {
        AtMostOnce,
        AtLeastOnce,
        ExactlyOnce
    }
}
