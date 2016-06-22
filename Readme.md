# DexCMS.HelpDesk

## You have just stumbled upon a superbly early version of a .Net CMS, right now it is an 
aggregation of shared code across several small websites. Soon it will be awesome, right now, it's in progress. :)

## DexCMS.Base Development Rules
* This library is for code specific to the Alerts domain
* It contains 3 libraries:
	* DexCMS.HelpDesk
		* For code not specific to mvc, webapi, etc.
	* DexCMS.HelpDesk.Host.WebApi
		* For code specific to WebApi sites for the host of a help desk server
* These libraries can depend on Core and Base libraries only.
* Before submitting a pull request, be sure you have installed the node packages and build the project in Release.
    * This includes the compiled dll into a /dist/ folder that consuming applications can use if I cut a new version off of your pull request.

## 0.1.0 (alpha)
* Initial Build
