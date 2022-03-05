# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## Unreleased
### Added
- Support for configuring port forwarding with a Unifi controller.
- Authentication and authorization with Azure AD
- Logging to file and console using Serilog
- Configuration secrets storage in Azure keyvault.
- Support for X-Forwarded headers

## [1.0.2] - 2019-12-06
### Fixed
- Updated the password authentication library to latest version to protect against timing attacks.

## [1.0.1] - 2019-04-18
### Added
- Initial release of Rstolsmark.WakeOnLanServer with WakeOnLan-functionality.
- Password protection