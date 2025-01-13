# Prototype API

Prototype API for feedback system for [Talenthive](https://experts.talenthive.fi).
Frontend can be found [here](https://github.com/SSuopanki/FeedbackPrototype).

## Installation

Setup Database using preferred method. I used MSSQL. Add database called **Review**. \
Then create Tables **Review Table** 
| Column Name | Data Type|
| ------------- | ------------- |
| ReviewId  | uniqueidentifier (PK) |
| ReviewTitle | varchar(50)  |
| ReviewText  |  varchar(MAX) |
| ReviewDate  | datetime  |
| UserId  | uniqueidentifier  |
| UserName  |  varchar(50) |
| Likes  | int  |
| Dislikes  | int  |
| Rating  | decimal(5,2)  |
| ProductId  | uniqueIdentifier  | 

Dont allow Nulls </Br>

</Br>

**Comment Table**

| Column Name | Data Type|
| ------------- | ------------- |
| CommentID | uniqueidentifier  |
| UserID | uniqueidentifier  |
| CommentText  |  varchar(MAX) |
| ReviewId  | uniqueidentifier  |

Dont allow Nulls

**Product Table**.

