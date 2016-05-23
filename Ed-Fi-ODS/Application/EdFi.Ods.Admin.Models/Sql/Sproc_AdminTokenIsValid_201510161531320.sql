﻿BEGIN
	EXEC('CREATE PROCEDURE [dbo].[AccessTokenIsValid] 
			@AccessToken uniqueidentifier,
			@TimeoutMinutes int = 30
	AS
		BEGIN
			DELETE FROM dbo.ClientAuthorizationCodes WHERE DATEDIFF(MINUTE, Expiration, GETDATE()) > @TimeoutMinutes;
			
			DELETE FROM dbo.ClientAccessTokens WHERE DATEDIFF(MINUTE, Expiration, GETDATE()) > @TimeoutMinutes;
			
			UPDATE ClientAccessTokens SET Expiration = DATEADD(MINUTE, @TimeoutMinutes, GETDATE()) WHERE ID = @AccessToken
			
			SELECT ac.[Name], ac.[Key], aeo.[EducationOrganizationId], app.ClaimSetName, v.NamespacePrefix, p.ProfileName
			FROM ClientAccessTokens cat 
				INNER JOIN ApiClients ac ON cat.ApiClient_ApiClientId = ac.ApiClientId AND cat.ID = @AccessToken
				INNER JOIN Applications app	ON app.ApplicationID = ac.Application_ApplicationID
				LEFT OUTER JOIN Vendors v ON v.VendorId = app.Vendor_VendorId
				--Outer join so client key is always returned even if no EdOrgs have been enabled
				LEFT OUTER JOIN [dbo].[ApiClientApplicationEducationOrganizations] acaeo ON acaeo.ApiClient_ApiClientId = cat.ApiClient_ApiClientId
				LEFT OUTER JOIN [dbo].[ApplicationEducationOrganizations] aeo ON aeo.ApplicationEducationOrganizationId = acaeo.ApplicationEducationOrganization_ApplicationEducationOrganizationId
				LEFT OUTER JOIN [dbo].[ProfileApplications] ap on ap.Application_ApplicationId = app.ApplicationId
				LEFT OUTer JOIN [dbo].[Profiles] p on p.ProfileId = ap.Profile_ProfileId
		END;')
END