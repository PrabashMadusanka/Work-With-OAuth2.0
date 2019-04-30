# Work-With-OAuth2.0
This is sample application to demonstrate the OAuth2.0 message flow. This a web application developed using C# ASP.net to upload files to google drive. In this web application, you would have a button where user would get redirected to google and the application would obtain an OAuth access token from google (after user authentication with google). Then application would provide a browse button where user could select the file to upload and it would be automatically uploaded to the google drive of the user. For uploading the file, application would use the OAuth access token obtained and call the google APIs

To Run the Application
1. Create Google API Console project (See Create Google API Console in  https://slitblogs.blogspot.com/2019/04/work-with-oauth-20.html )
2. Save the Client ID and Client secret to web.config file
3. Download ASPSnippets.GoogleAPI.dll form https://www.aspsnippets.com/DownloadFile.aspx?File=ASPSnippets.GoogleAPI.dll and add that to      bin folder
3. Run the project using Visual studio
