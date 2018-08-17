# Version 1.8.00

### Bug fixes
None.

See list of bug fixes for native platforms:

* iOS Mobile SDK for CA Mobile API Gateway [Change Log](https://github.com/CAAPIM/iOS-MAS-Foundation/blob/Stable/CHANGELOG.md#version-1800)
* Android™ Mobile SDK for CA Mobile API Gateway [Change Log](https://github.com/CAAPIM/Android-MAS-SDK/blob/Stable/ChangeLog.md#version-1800)

### Enhancement
* The Mobile SDK always enforced id_token validation during device registration, and user authentication which could potentially cause failure if id_token's signing algorithm is not supported by the Mobile SDK.  The Mobile SDK now provides an option to enable or disable id_token validation for unsupported id_token signing algorithm. [US514785]
* The Mobile SDK now supports offline logout functionality. Logout call can be specified to delete or keep credentials upon error. [US520138]
* MASFoundation.iOS updated with latest iOS 1.8.00 native version
* MASFoundation.Android updated with latest Android 1.8.00 native version

### Deprecated methods
- `MASUser.CurrentUser.LogoutWithCompletion()` and `MASUser.CurrentUser.LogoutAsync()` are now deprecated to support new feature. Please use `MASUser.CurrentUser.Logout(bool, MASCompletionErrorBlock)` or `MASUser.CurrentUser.LogoutAsync(bool)` to perform user logout. [US520138]

# Version 1.7.10

### Bug fixes
None.

See list of bug fixes for native platforms:

* iOS Mobile SDK for CA Mobile API Gateway [Change Log](https://github.com/CAAPIM/iOS-MAS-Foundation/blob/Stable/CHANGELOG.md#version-1710)
* Android™ Mobile SDK for CA Mobile API Gateway [Change Log](https://github.com/CAAPIM/Android-MAS-SDK/blob/Stable/ChangeLog.md#version-1710)

### Enhancement
* MASFoundation.iOS updated with latest iOS 1.7.10 version
* MASFoundation.Android updated with latest Android 1.7.10 version

### Deprecated methods
None.

# Version 1.7.00

### Bug fixes
None.

### New features
Initial Release of Xamarin MASFoundation.

### Deprecated methods
None. 

 [mag]: https://docops.ca.com/mag
 [mas.ca.com]: http://mas.ca.com/
 [docs]: http://mas.ca.com/docs/
 [blog]: http://mas.ca.com/blog/

 [releases]: ../../releases
 [contributing]: /CONTRIBUTING.md
 [license-link]: /LICENSE

