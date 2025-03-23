OVERVIEW

The Municipal Services Application is designed to facilitate citizen engagement with municipal services, allowing residents to report issues, view local events, and check service request statuses. The application provides a user-friendly interface to enhance the experience of engaging with municipal services, and has a language change function which allows users to select a language they feel more comfortable with and advanced data structures for efficiency.
 
FEATURES

•	The application supports multiple languages, and users can change the application's language to enhance accessibility for all users.
Report Issues Features
REPORTING ISSUES 
Reporting Issues: Users can report issues, where they must enter the location, select the category of the issue, describe the issue, attach media related to the issue such as an image, and then submit the issue
•	Location suggestion: Once users start inputting the location, a geolocation feature is presented in a combo box beneath the location text field, which suggests possible location names as the user types by using a map API.
•	Category Selection: Users can select the category in which their issue falls from a list box of options. 
•	Issue Description: Users can describe their issue in the provided textbox.
•	Media Uploads: Users can attach, remove and preview media files of their choosing. They can upload multiple and can select which one to view from the list box provided.
•	Progress bar: A progress bar is at the top of the page to indicate how far the user is in completing their report
•	Submitting reports: Users can click on “Submit” to submit their reports

VIEWING REPORTED ISSUES

Viewing reported issues: Users can view all of the issues that they submitted in a table form, which includes the unique generated request ID, location, category, description, submission date and the ability to view files
•	Request ID: When a user submits a report, their report is assigned a random Request ID to help them track their report.
•	Inputted fields: The location, category and description entered are all displayed in the table for users to easily view. 
•	View Files: Users can view the files that they updated by clicking the “View Files” button in their reports row, this leads them to a new page where they can select the file they wish to view (in the event that they have multiple files) and it will be displayed

Local Events and Announcements Features

Local Events and Announcements: Users can view upcoming events and announcements organised by category and date.
•	Search Functionality: Search for events by name, category, or date. Alternatively, they can search for events by all criteria at the same time.
•	Event Recommendations: Displays recommendations based on user search history.
•	Priority Queue: Events are prioritised for display based on date.
•	User Search History: Tracks and displays the frequency of searches.
Service Request Status Features
• Service Request Status: Users can view all of the issues they reported in a table form, and can search for their reported issues by using their unique request ID and clicking search.

SYSTEM REQUIREMENTS

•	Windows Operating System (Windows 10 or later recommended)

•	NET Framework 4.7.2 or .NET Core

•	Visual Studio 2019 or later for development

•	Additional Libraries: JSON.Net

 
INSTALLATION AND RUN

1. Clone the repository or download it from GitHub
https://github.com/ST10202241/PROG7312ST10202241/ ,
2. Unzip the downloaded folder if required
2. Open the solution file in Visual Studio.
3. Restore any NuGet packages if prompted.
4. Run the project by clicking Run or double-click the PROG7312ST10202241.exe file in the bin/release folder to launch the application application
5. If you encounter any permission issues, right-click the executable and select "Run as Administrator."
   
USAGE

Main Menu

Upon start-up, you will see the main menu displaying the following options:
• Report Issues: Click this button to report an issue.
• Local Events and Announcements: Click this button to see local events.
• Service Request Status: Click this button to see the request service statement for reported issues.
• Admin Login Button: Click this button to be directed to the admin login page for updating statuses.

Report Issues

•	Click on the Report Issues button.
•	A new form will appear with the following input fields:
•	Location: Enter the specific location of the issue. As the user types, a combo box will present suggesting options based on what the user is entering.
•	Category: Select the category of the issue from the dropdown list (e.g., sanitation, roads, utilities).
•	Description: Provide a detailed description of the issue.
•	Media Attachment: Click the "Attach Media" button to select images or documents related to the reported issue.
•	Submit: Once all the fields are filled out, click the Submit button to finalise and save your report.
•	View All Reports: Clicking on this takes you to another page, where you can see all of the
•	detail of all of the reports that you input, such as location, as well as view your image by
•	clicking or double-clicking on it
•	Back to Main Menu: Click this button to return to the main menu.

Local Events and Announcements 

SEARCHING FOR EVENTS

1.	Search by Name
•	Enter the name of the event in the search box.
•	Click the Search button.
•	The application will display matching events in the recommendations list.

2.	Search by Category
•	Select a category from the dropdown.
•	Click the Search by Category button.
•	Recommended events for that category will be displayed.

3.	Search by Date
•	Select a date using the date picker.
•	Click the Search by Date button.
•	The application will display events occurring on the selected date.

4.	Combined Search
•	Enter a name, select a category, and choose a date.
•	Click the Search All button.
•	The application will filter events based on all criteria provided.

Service Request Status

SEARCHING FOR A SPECIFIC REPORTED ISSUE

•	Enter the unique “request ID” of the reported number
•	Click the Search button
•	The application will present the details of the report with that request ID

Employee Login 

LOG IN AS AN EMPLOYEE

•	After navigating to the first form that appears when the application starts clicking on Admin Login
•	Enter the Admin’s login details
•	Click login

Service Request Graph

CHANGING THE STATUS

•	Enter the Request ID of the Request that status needs to be updated in the provided textbox.
•	Enter the updated status
•	Click update

VIEWING RECOMMENDATIONS

The application tracks your search history and shows frequent searches in the Recommendations List. Based on your selected category, related events will be displayed for further exploration.

CLEARING SEARCH RESULTS

To clear search results, click the Clear button. This will reset the search box and clear the recommendations.

NAVIGATING BACK TO THE MAIN MENU

Click the Back to Main Menu button to return to the main menu of the application.

LANGUAGE SELECTOR

•	The application includes a language selector for changing the interface language.
•	The language options are loaded from a resource file, allowing users to select their preferred language.
•	Changing the language will update all interface elements to the selected language, enhancing accessibility for non-English speakers.

DATA STRUCTURES USED

Data Structures and Their Contributions

1. RED-BLACK TREE (SERVICE REQUEST SEARCH)
The Red-Black Tree is used to efficiently manage the service request data, particularly for operations that require quick search and retrieval by Request ID. It is a self-balancing binary search tree and makes sure that no path from the root to the leaf is more than twice as long as any other, maintaining logarithmic time complexity O(log n) for insertion, deletion, and search operations.
When a user searches for a service request by Request ID, the Red-Black Tree allows for quick and efficient retrieval. For instance, if there are 10,000 service requests, the tree ensures that search operations are efficient, only taking approximately logv2(10000)≈14 comparisons.

2. MINHEAP (PRIORITY SCHEDULING)
The MinHeap is used to maintain a minimum priority queue for time-sensitive service requests. It ensures that the service request with the earliest submission date or highest priority is always accessible at the root of the heap.
When handling service requests, the MinHeap allows the system to quickly identify and process the most urgent requests. For example, if a service request needs immediate attention, it is placed at the top of the heap, ensuring it is addressed first.

3. BINARY SEARCH TREE (BST) (ORDERED SERVICE REQUESTS)
Stores and manages service requests in a structured order.
Enables efficient in-order traversal to retrieve service requests in a sorted manner.

4. AVL TREE (BALANCED DATA RETRIEVAL)
Ensures balanced binary search for optimal data retrieval.
Guarantees balanced height for fast search, insertion, and deletion operations.

5. TRIE (PREFIX-BASED SEARCH)
Facilitates efficient prefix-based searching and auto-complete features.
Enables fast lookup and insertion of strings, such as search terms or service request IDs.

6. PRIORITYQUEUE (EVENT SORTING BY DATE)
The PriorityQueue is used to organise and retrieve events by their upcoming dates. It ensures that events are prioritised based on their scheduled dates, with the earlier events being processes first.
This structure ensures that the earliest upcoming event can be retrieved in constant time O(1), allowing for efficient event management and scheduling.

7. HASHSET (CATEGORY MANAGEMENT)
The HashSet is used to track unique event categories within the system. It ensures that there are no duplicate categories in the category list.
When adding a new category, the HashSet checks for uniqueness in constant time O(1), ensuring efficient management of event categories.

8. SORTEDDICTIONARY (DATE-ORGANIZED EVENTS)
The SortedDictionary maps events to their dates for efficient retrieval. It sorts events by date, allowing for quick access to all events occurring on a particular date.
When displaying events for a specific date, the SortedDictionary allows for quick retrieval and display of all events scheduled for that date.

9. GRAPH (SERVICE REQUEST DEPENDENCIES)
The Graph represents dependencies or relationships among service requests. It visualises how different service requests are connected and interdependent.
By visualising connected service requests in a graph structure, the system can identify and manage dependencies more effectively, ensuring that related requests are processed in the correct order.
LICENSE
This project is licensed under the MIT License.
