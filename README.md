# A simple webapp template

This template can be used to start a new CSharp web app project, as well as for coding dojos and various exercises.

## Run the application with

Open the solution with VisualStudio, MonoDevelop or Xamarin Studio and hit 'Run'

## Deploy the application to Heroku

Purpose: deploy the application on heroku.

Before calling this script, you should:

0. register yourself on Heroku
1. install the "heroku toolbelt" (see instructions on heroku's website)
2. Login on heroku
    heroku login
3. create a new application on Heroku
	heroku create <yourappname> --buildpack https://github.com/kylehodgson/heroku-buildpack-mono.git
4. deploy executing:
	git push heroku master
5. Open the site
	heroku open

 If it does not work, execute
    heroku logs
