# CollegeBookRental
[CollegeBookRentalLink](https://collegebookrentaldonnyves.azurewebsites.net/)


*An application where you can rent books at a fair and reasonable price.* 

<a name="contents"></a>

<a name="toc"></a>
# Table of Contents
1. [What is College Book Rental?](#introduction)
2. [Requirements](#requirements)
3. [Currently Working On](#working)
4. [Class Diagrams](#diagrams)
5. [SQL Scripts](#scripts)
6. [Wire Frames/Screen Shots](#wireframes)
7. [Testing](#testing)
8. [Prioritized Backlog Items](#backlog)
9. [Screenshots of Testing](#testshots)
10. [Future Implementation](#future)




<a name="introduction"></a>
## What is College Book Rental? 

College Book Store is an ASP.NET (Framework) rental system application that utilizes admin and user accounts.  The administrator sets the price for the book rentals and the user chooses a rental plan that satisfies their needs.  




<a name="requirements"></a>
## Requirements  
	
  - Requirements (doc): [Project CollegeGame.pptx](https://github.com/donnyves/CollegeBookRental/files/3076989/Project.CollegeGame.pptx)
---



  
  <a name="working"></a>
## Currently Working On
  
- Making the search bar on the home page functional.
- Creating a view for the user accounts.
- Making the admin account visible only to the administrator via login.
- Creating security measures for both the user and administrator.  
  
<a name="diagrams"></a>
## Class Diagrams 


![ClassDiagram](https://user-images.githubusercontent.com/40510674/56258172-7fa4cd80-6083-11e9-823a-efb39b5d8382.PNG)




<a name="scripts"></a>
## SQL Scripts
**SQL Scripts**

![SQLScripts](https://user-images.githubusercontent.com/40510674/56181491-920b0280-5fc2-11e9-9a1c-b19e427bbb0b.PNG)

  <a name="wireframes"></a>
## WireFrames/Screen Shots

## Wire Frames

![Home](https://user-images.githubusercontent.com/40510674/57640187-9a753f80-7566-11e9-9309-0db1cbb877f7.PNG)
![Genre](https://user-images.githubusercontent.com/40510674/57640202-a06b2080-7566-11e9-99b9-78729f601112.PNG)
![CreateNewGenre](https://user-images.githubusercontent.com/40510674/57640213-a82ac500-7566-11e9-8c0b-2f0d09a5e444.PNG)
![DeleteGenre](https://user-images.githubusercontent.com/40510674/57640220-af51d300-7566-11e9-9d48-73aab0d4f259.PNG)

**Screenshots of the Opening Page**
![HomePageScreenShot](https://user-images.githubusercontent.com/40510674/57746636-e919fb00-7686-11e9-9ff6-0b56779008a8.PNG)

--- 

<a name="testing"></a>
## Testing
**Testing**


|Req #|Requirement Description|Test Method| Test Procedure|Unit Test Passed?|Time Stamp|
| ------------- |-------------| -----| --------|------|-----|
|1|Create Interactive and Dynamic features  |Inspect CSS and Javscript  |Unit Test |Not Tested|27APR2019|
|2|Complete Get and Post Actions  |Demonstrate the Changing Of Views|Unit Test|Not Tested|27APR2019|
|3|CRUD Operations|Demonstrate the Creatation of Tables in DB|Unit Test |Not Tested|27APR2019  |
|4|Connect DB to CRUD Operations|Demonstrate the Creatation of DB in SSMS|Integration Test|Not Tested| 27APR2019  |
|5|Create an About and Contact page|Inspect a View for both pages|Unit Test|Not Tested|27APR2019|
|6|Upload Book Images from DB|Inspect the DB |Integration Test|Not Tested|27APR2019|
|7|Create Decriptions View of the Books|Inspect Changes in View |Unit Test|Not Tested| 27APR2019 |
|8|Create a Pricing System for the Books|Demonstrate the Display of Price in View|Unit Test|Not Tested|27APR2019  |
|9|Create a Tracking System of the Books|Demonstrate in view and DB|Integration Test|Not Tested|27APR2019  |
|10|Create a Comment Page|Demonstrate View and DB|Integration Test|Not Tested|27APR2019  |
|11|Create a User Login |Demonstrate in Authentication Login View |Security Test|Not Tested| 27APR2019 |
|12|Create a System to Track Membership  |Demonstrate in View and DB   |Inegration Test|Not Tested| 27APR2019|
|13|Create a an E-mail Verification System |Demonstrate in Views,Models,Controllers |Unit Test|Not Tested|27APR2019  |
|14|Create Thumbnails to Display Books|Demonstrain on Views, Models, Controllers|Unit Test|Not Tested|12MAY2019|


  
---

- (TRR  Test Readiness Review)

	- Plan
- [x] Create New Genre Test
- [ ] Create New Book Test
- [ ] Create New User Test
- [ ] Create New Memebership Test
- [ ] Create New BookRental Test
- [ ] Indicates Selected Category Test
- [ ] Add Quantity Test
- [ ] Calculate Total Test
- [ ] Clear Contents Test
- [ ] View Contents Test
- [ ] Cannot Process Empty Contents Test
- [ ] Can Submit Rental Order Test
---

<a name="backlog"></a>
## Prioritized Backlog Items

|Req #|Backlog Item|
| ------------- |-------------|
|8|Create a Pricing System for the Books|
|9|Create a Tracking System of the Books|
|11|Create a User Login |Demonstrate in Authentication Login View |
|13|Create a an E-mail Verification System |

---


<a name="testshots"></a>
## Screenshots of Testing
  ![UnitTest-1](https://user-images.githubusercontent.com/40510674/56087261-09eaf880-5e1c-11e9-8e34-7d2a8d43a277.PNG)
---





---




---





<a name="future"></a>
## Future Implementation 

- Create a secure email confirmation system.
- Create a comment section where users can give suggestion to improve the system or suggest books.
- Create a book tracking system for the administrator.
- Connect book inventory to BLOB storage, if the inventory becomes too large.
- Add a video book review link, where users can upload video of their book critiques.











---
 [Back to the Table of Contents](#contents)
