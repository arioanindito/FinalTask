# Developing Software System
## _The Final Task - Ario Anindito (VUM 2016082)_

This is my final project for Developing Software System module.  
In order to run the project, please change the string connection to your own server. (I'm using SQLEXPRESS)  

I uploaded my updated database within this project, under the name **Ario_Final.bak**  
Please restore my backup database to your database server. It contains all the necessery data such as User Role, User Database, seed, etc.  

The project consists of four pages.
1. Book Overview
2. Members
3. Loans
4. Satus

All pages can be accessible with full function (Create,Edit,Delete,Details) with logged-in Admin account.  
Please go to login page and read the insturction at that page, to logged-in as an Admin or User.

## Book Overview Page

- List of all books
- CRUD (Create, Read, Update, Delete) a new book along the photo upload with file picker control


## Member Page

- List of all members in database
- CRUD a new member along the status information from status page (e.g Student, Lecturer, Staff, Public)

## Status Page

- List of all member statuses
- CRUD a new status for borrowers (e.g Student Lecturer, Staff, Public)


## Loans Page

- List of all loans in database
- CRUD a new loans along the member information from member page


## Features

- An overview page and an add/detail/edit page where the records can be edited.
- The logged-in user able to delete records from the overview page and/or from the details page.
- File picker control for selecting files and save them on the server.
- Restrict parts to users in specific roles.
- Modifications of the records can be done only by logged-in users.
- The modified records contain information about the DateTime of creating/editing and the user that created/edited the record.


[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

   [dill]: <https://github.com/joemccann/dillinger>
   [git-repo-url]: <https://github.com/joemccann/dillinger.git>
   [john gruber]: <http://daringfireball.net>
   [df1]: <http://daringfireball.net/projects/markdown/>
   [markdown-it]: <https://github.com/markdown-it/markdown-it>
   [Ace Editor]: <http://ace.ajax.org>
   [node.js]: <http://nodejs.org>
   [Twitter Bootstrap]: <http://twitter.github.com/bootstrap/>
   [jQuery]: <http://jquery.com>
   [@tjholowaychuk]: <http://twitter.com/tjholowaychuk>
   [express]: <http://expressjs.com>
   [AngularJS]: <http://angularjs.org>
   [Gulp]: <http://gulpjs.com>

   [PlDb]: <https://github.com/joemccann/dillinger/tree/master/plugins/dropbox/README.md>
   [PlGh]: <https://github.com/joemccann/dillinger/tree/master/plugins/github/README.md>
   [PlGd]: <https://github.com/joemccann/dillinger/tree/master/plugins/googledrive/README.md>
   [PlOd]: <https://github.com/joemccann/dillinger/tree/master/plugins/onedrive/README.md>
   [PlMe]: <https://github.com/joemccann/dillinger/tree/master/plugins/medium/README.md>
   [PlGa]: <https://github.com/RahulHP/dillinger/blob/master/plugins/googleanalytics/README.md>
