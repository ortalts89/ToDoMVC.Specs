Feature: Add New Task
	

Scenario: Add task and see it in the end of the list
	Given I have open the todos screen
	When i add new task
	Then the task will be added to the end of the tasks list

Scenario: See new task as active
	Given i have open the todos screen
	When i add new task
	Then the task will be displayed as active in the tasks list

Scenario: Adding task in Hebrew
Given i have open the todos screen
When i add new task in Hebrew
Then the task name will be aligned to right

Scenario: Adding task with a long text
Given i have open the todos screen
When i add task with a long name
Then the task name will be displayed in multiple rows in the tasks list

Scenario: Add task and refresh the page to see the updated task
Given i have added new task
When i refresh the todos page
Then the added task will be displayed in the tasks list


Scenario: Trim leading and trailing white-space characters from task name
Given i have open the todos screen
When i add new task with leading and trailing white-space characters in task name
Then  the white-space characters will be trimmed from task name

Scenario: Not allow to add a task that contains only spaces
Given i have open the todos screen
When i try to add task with name that contains only spaces
Then the task won't be added to the tasks list