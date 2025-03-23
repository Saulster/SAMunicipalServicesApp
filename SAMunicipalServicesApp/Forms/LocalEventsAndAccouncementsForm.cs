using System.Collections.Generic;
using PROG7312ST10202241.Models;
using System;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using PROG7312ST10202241.Forms;

namespace PROG7312ST10202241
{
    public partial class LocalEventsAndAccouncementsForm : Form
    {
        /// <summary>
        ///Data structures to manage events and user interactions
        /// </summary>
        private SortedDictionary<DateTime, Queue<Event>> eventsByDate;
        private HashSet<string> uniqueCategories;
        private Stack<string> userSearchHistory;
        private Dictionary<string, int> searchFrequency;
        private PriorityQueue<Event, DateTime> eventPriorityQueue;
        private ResourceManager resourceManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEventsAndAccouncementsForm"/> class.
        /// </summary>
        public LocalEventsAndAccouncementsForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(LocalEventsAndAccouncementsForm).Assembly);
            ApplyLocalization();
            InitializeDataStructures();
            LoadSampleData(); // Load sample data instead of database data
            DisplayEvents(); // Display events on form load
        }

        /// <summary>
        /// Applies localization to form controls.
        /// </summary>
        private void ApplyLocalization()
        { 
            this.Text = resourceManager.GetString("LocalEventsAndAnnouncementsTitle");
            nameOfEventLbl.Text = resourceManager.GetString("nameOfEventLbl");
            searchBtn.Text = resourceManager.GetString("searchBtn"); 
            categoryLbl.Text = resourceManager.GetString("CategoryLbl");
            btnSearchByCategory.Text = resourceManager.GetString("btnSearchByCategory");
            dateLbl.Text = resourceManager.GetString("dateLbl");
            btnSearchByDate.Text = resourceManager.GetString("btnSearchByDate");
            btnSearchWithAll.Text = resourceManager.GetString("btnSearchWithAll");
        }

        /// <summary>
        /// Initializes data structures for managing events and user interactions.
        /// </summary>
        private void InitializeDataStructures()
        {
            eventsByDate = new SortedDictionary<DateTime, Queue<Event>>();
            uniqueCategories = new HashSet<string>();
            userSearchHistory = new Stack<string>();
            searchFrequency = new Dictionary<string, int>(); // Track search frequency
            eventPriorityQueue = new PriorityQueue<Event, DateTime>();
        }

        /// <summary>
        /// Loads sample event data into the application.
        /// </summary>
        private void LoadSampleData()
        {
            // Sample events with compact categories in Cape Town
            Event event1 = new Event("Music Festival", "Entertainment", new DateTime(2025, 12, 15), "Cape Town Stadium");
            Event event2 = new Event("Gourmet Food Festival", "Food", new DateTime(2025, 12, 5), "Company's Garden");
            Event event3 = new Event("Tech Innovation Conference", "Technology", new DateTime(2025, 12, 1), "Cape Town International Convention Centre");
            Event event4 = new Event("Contemporary Art Exhibition", "Art", new DateTime(2025, 10, 20), "Zeitz MOCAA");
            Event event5 = new Event("Book Fair", "Literature", new DateTime(2025, 10, 18), "The Book Lounge");
            Event event6 = new Event("Film Screening", "Entertainment", new DateTime(2025, 11, 10), "The Labia Theatre");
            Event event7 = new Event("Wine Tasting", "Food", new DateTime(2025, 11, 7), "Constantia Wine Estate");
            Event event8 = new Event("Startup Pitch Event", "Technology", new DateTime(2025, 12, 3), "Workshop17");
            Event event9 = new Event("Sculpture Workshop", "Art", new DateTime(2025, 10, 25), "Art + Design Cape Town");
            Event event10 = new Event("Science Expo", "Education", new DateTime(2025, 11, 15), "Cape Town Science Centre");
            Event event11 = new Event("Jazz Night", "Entertainment", new DateTime(2025, 10, 22), "The Crypt Jazz Restaurant");
            Event event12 = new Event("Cooking Class", "Food", new DateTime(2025, 11, 12), "The Kitchen at 36");
            Event event13 = new Event("AI Symposium", "Technology", new DateTime(2025, 12, 6), "UCT Graduate School of Business");
            Event event14 = new Event("Fashion Show", "Art", new DateTime(2025, 10, 28), "Cape Town Fashion Week Venue");
            Event event15 = new Event("Poetry Reading", "Literature", new DateTime(2025, 11, 2), "The Poetry Cafe");
            Event event16 = new Event("Charity Run", "Health", new DateTime(2025, 10, 30), "Green Point Park");
            Event event17 = new Event("Photography Workshop", "Art", new DateTime(2025, 11, 1), "South African Museum");
            Event event18 = new Event("Theater Performance", "Entertainment", new DateTime(2025, 11, 8), "Artscape Theatre Centre");
            Event event19 = new Event("Tech Meet-up", "Technology", new DateTime(2025, 11, 15), "V&A Waterfront");
            Event event20 = new Event("Culinary Challenge", "Food", new DateTime(2025, 11, 20), "Gourmet Food Market");
            Event event21 = new Event("Holiday Craft Market", "Art", new DateTime(2025, 12, 1), "Greenmarket Square");
            Event event22 = new Event("Dance Workshop", "Art", new DateTime(2025, 12, 5), "The Dance Factory");
            Event event23 = new Event("Blockchain Seminar", "Technology", new DateTime(2025, 12, 10), "The Business Centre");
            Event event24 = new Event("Christmas Concert", "Entertainment", new DateTime(2025, 12, 15), "St. George's Cathedral");
            Event event25 = new Event("DIY Crafts Fair", "Art", new DateTime(2025, 12, 20), "Community House");
            Event event26 = new Event("Book Signing", "Literature", new DateTime(2025, 12, 22), "Exclusive Books");
            Event event27 = new Event("Health and Fitness Expo", "Health", new DateTime(2025, 11, 25), "Cape Town Convention Centre");
            Event event28 = new Event("Educational Workshop", "Education", new DateTime(2025, 11, 30), "International Convention Centre");
            Event event29 = new Event("Local History Tour", "Education", new DateTime(2025, 10, 29), "Robben Island Museum");
            Event event30 = new Event("Environmental Awareness Campaign", "Awareness", new DateTime(2025, 12, 18), "Cape Town City Hall");
            Event event31 = new Event("Outdoor Movie Night", "Entertainment", new DateTime(2025, 10, 16), "The Promenade, Sea Point");
            Event event32 = new Event("Farmers Market", "Food", new DateTime(2025, 10, 21), "The Old Biscuit Mill");
            Event event33 = new Event("Coding Bootcamp", "Technology", new DateTime(2025, 11, 5), "WeWork, Cape Town");
            Event event34 = new Event("Craft Beer Festival", "Food", new DateTime(2025, 11, 15), "Cape Town Waterfront");
            Event event35 = new Event("Art in the Park", "Art", new DateTime(2025, 10, 24), "Green Point Park");
            Event event36 = new Event("Public Speaking Workshop", "Education", new DateTime(2025, 10, 31), "Cape Town Business School");
            Event event37 = new Event("Yoga Retreat", "Health", new DateTime(2025, 11, 20), "Ceres Valley");
            Event event38 = new Event("Graphic Novel Workshop", "Art", new DateTime(2025, 11, 11), "Comic Book Store");
            Event event39 = new Event("Stand-up Comedy Night", "Entertainment", new DateTime(2025, 11, 13), "The Cape Town Comedy Club");
            Event event40 = new Event("Cheese and Wine Pairing", "Food", new DateTime(2025, 11, 9), "La Motte Wine Estate");
            Event event41 = new Event("Web Development Conference", "Technology", new DateTime(2025, 12, 8), "CTICC");
            Event event42 = new Event("Local Music Showcase", "Entertainment", new DateTime(2025, 11, 4), "The Waiting Room");
            Event event43 = new Event("Art Therapy Session", "Art", new DateTime(2025, 11, 14), "Healing Centre");
            Event event44 = new Event("Smart Cities Forum", "Technology", new DateTime(2025, 12, 2), "City Hall");
            Event event45 = new Event("Nutrition Workshop", "Health", new DateTime(2025, 11, 19), "Nutrition Centre");
            Event event46 = new Event("Historical Walking Tour", "Education", new DateTime(2025, 11, 17), "Cape Town City Centre");
            Event event47 = new Event("Christmas Craft Fair", "Art", new DateTime(2025, 12, 12), "The Castle of Good Hope");
            Event event48 = new Event("Volunteer Day", "Awareness", new DateTime(2025, 12, 9), "Various Locations");
            Event event49 = new Event("Cultural Dance Performance", "Entertainment", new DateTime(2025, 12, 13), "Artscape Theatre");
            Event event50 = new Event("Mental Health Awareness Seminar", "Awareness", new DateTime(2025, 12, 15), "Cape Town Convention Centre");

            // Adding events to the data structures
            AddEvent(event1);
            AddEvent(event2);
            AddEvent(event3);
            AddEvent(event4);
            AddEvent(event5);
            AddEvent(event6);
            AddEvent(event7);
            AddEvent(event8);
            AddEvent(event9);
            AddEvent(event10);
            AddEvent(event11);
            AddEvent(event12);
            AddEvent(event13);
            AddEvent(event14);
            AddEvent(event15);
            AddEvent(event16);
            AddEvent(event17);
            AddEvent(event18);
            AddEvent(event19);
            AddEvent(event20);
            AddEvent(event21);
            AddEvent(event22);
            AddEvent(event23);
            AddEvent(event24);
            AddEvent(event25);
            AddEvent(event26);
            AddEvent(event27);
            AddEvent(event28);
            AddEvent(event29);
            AddEvent(event30);
            AddEvent(event31);
            AddEvent(event32);
            AddEvent(event33);
            AddEvent(event34);
            AddEvent(event35);
            AddEvent(event36);
            AddEvent(event37);
            AddEvent(event38);
            AddEvent(event39);
            AddEvent(event40);
            AddEvent(event41);
            AddEvent(event42);
            AddEvent(event43);
            AddEvent(event44);
            AddEvent(event45);
            AddEvent(event46);
            AddEvent(event47);
            AddEvent(event48);
            AddEvent(event49);
            AddEvent(event50);

        }

        /// <summary>
        /// Adds an event to the data structures for management and display.
        /// </summary>
        /// <param name="eventItem">The event to be added.</param>
        private void AddEvent(Event eventItem)
        {
            // Add to SortedDictionary (by date)
            if (!eventsByDate.ContainsKey(eventItem.Date))
            {
                eventsByDate[eventItem.Date] = new Queue<Event>();
            }
            eventsByDate[eventItem.Date].Enqueue(eventItem); // Add to queue for FIFO ordering

            // Add to PriorityQueue (based on event date)
            eventPriorityQueue.Enqueue(eventItem, eventItem.Date); // Add to priority queue (soonest events first)

            // Add to category HashSet (unique categories)
            uniqueCategories.Add(eventItem.Category);
        }

        /// <summary>
        /// Displays events on the form.
        /// </summary>
        private void DisplayEvents()
        {
            listBoxEvents.Items.Clear(); // Clear previous items

            foreach (var dateQueue in eventsByDate)
            {
                foreach (var eventItem in dateQueue.Value)
                {
                    listBoxEvents.Items.Add(eventItem); // Display each event
                }
            }
            UpdateCategoryComboBox(); // Update category dropdown
        }

        /// <summary>
        /// Update the category ComboBox (assume comboBoxCategories is a ComboBox control on your form)
        /// </summary>
        private void UpdateCategoryComboBox()
        {
                comboBoxCategories.Items.Clear(); // Clear existing items
                var categoriesArray = uniqueCategories.ToArray(); // Convert to array
                comboBoxCategories.Items.AddRange(categoriesArray); // Add unique categories
            
        }


        /// <summary>
        /// Handles the search button click event.
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs args)
        {
            ClearSearchResults();
            string searchTerm = searchTextBox.Text.Trim();
            List<Event> filteredEvents = GetEventsByName(searchTerm);
            DisplaySearchResults(filteredEvents);

            // Record user search (only name is provided here)
            RecordUserSearch(searchTerm, null, DateTime.MinValue);
        }
        /// <summary>
        /// Displays the Search results
        /// </summary>
        private void DisplaySearchResults(List<Event> eventsToDisplay)
        {
            listBoxRecommendations.Items.Clear(); // Clear previous recommendations

            // Debugging line
           
            foreach (var eventItem in eventsToDisplay)
            {
                listBoxRecommendations.Items.Add(eventItem); // Display each event in recommendations
            }
        }

        /// <summary>
        /// Clears the Search results
        /// </summary>
        private void ClearSearchResults()
        {
            listBoxRecommendations.Items.Clear(); // Clear recommendations
            comboBoxCategories.SelectedItem = null; // Clear category selection
        }
        /// <summary>
        /// Handles the search all button click event.
        /// </summary>
        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ClearSearchResults();

            string searchTerm = searchTextBox.Text.Trim();
            string selectedCategory = comboBoxCategories.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePicker.Value.Date;

            // Get events based on all criteria
            var allFilteredEvents = GetEventsByAllCriteria(searchTerm, selectedCategory, selectedDate);
            DisplaySearchResults(allFilteredEvents);

            // Record user search (combining all criteria)
            RecordUserSearch(searchTerm, selectedCategory, selectedDate);
        }

        /// <summary>
        /// Handles the list to get all events by their relevant criteria
        /// </summary>
        private List<Event> GetEventsByAllCriteria(string name, string category, DateTime date)
        {
            return eventsByDate.Values
                .SelectMany(queue => queue)
                .Where(e =>
                    (string.IsNullOrEmpty(name) || e.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(category) || e.Category == category) &&
                    (e.Date.Date == date)
                )
                .ToList();
        }
        /// <summary>
        /// Handles updating of the frequency of search recommendations
        /// </summary>
        private void UpdateFrequentSearchRecommendations()
        {
            listBoxFrequentSearchRecommendations.Items.Clear(); // Clear previous recommendations

            // Sort searches by frequency and display top searches
            var sortedFrequencies = searchFrequency.OrderByDescending(kvp => kvp.Value).ToList();

            foreach (var search in sortedFrequencies)
            {
                listBoxFrequentSearchRecommendations.Items.Add($"{search.Key} (Searched {search.Value} times)");
            }
        }
        /// <summary>
        /// Record user search for recommendations (use a stack to store the search history)
        /// </summary>
        private void RecordUserSearch(string name, string category, DateTime date)
        {
            string searchKey = "";

            // Append name if provided
            if (!string.IsNullOrEmpty(name))
            {
                searchKey += $"Name: {name} ";
            }

            // Append category if provided
            if (!string.IsNullOrEmpty(category))
            {
                searchKey += $"Category: {category} ";
            }

            // Append date if provided
            if (date != DateTime.MinValue) // Ensure date is valid
            {
                searchKey += $"Date: {date.ToShortDateString()}";
            }

            // Store the combined search key
            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                userSearchHistory.Push(searchKey); // Push the search query to the stack

                // Update search frequency
                if (searchFrequency.ContainsKey(searchKey))
                {
                    searchFrequency[searchKey]++;
                }
                else
                {
                    searchFrequency[searchKey] = 1;
                }

                UpdateFrequentSearchRecommendations(); // Update the listbox with new recommendations
            }
        }



        /// <summary>
        /// Show event recommendations based on the user's search history
        /// </summary>
        /// <param name="selectedCategory"></param>

        private void ShowRecommendations(string selectedCategory)
        {
            listBoxRecommendations.Items.Clear(); // Clear previous recommendations

            // Check if a category is selected and display related events
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                var recommendedEvents = eventsByDate
                    .SelectMany(kvp => kvp.Value) // Access all events
                    .Where(e => e.Category == selectedCategory) // Filter by the selected category
                    .ToList();

                // Display recommendations based on selected category
                foreach (var eventItem in recommendedEvents)
                {
                    listBoxRecommendations.Items.Add($"Recommended: {eventItem}");
                }
            }

            // Optionally, show past search recommendations from userSearchHistory
            foreach (var searchQuery in userSearchHistory)
            {
                listBoxRecommendations.Items.Add($"Based on search: {searchQuery}");
            }
        }
        /// <summary>
        /// Close application on form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalEventsAndAccouncementsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// handles navigaione back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToMainMenuBtn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
        /// <summary>
        /// Handles the search by date button click event.
        /// </summary>
        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            DateTime selectedDate = dateTimePicker.Value.Date;
            List<Event> eventsOnSelectedDate = GetEventsOnDate(selectedDate);
            DisplaySearchResults(eventsOnSelectedDate);

            // Record user search (only date is provided here)
            RecordUserSearch(null, null, selectedDate);
        }

        private List<Event> GetEventsOnDate(DateTime date)
        {
            if (eventsByDate.ContainsKey(date))
            {
                return eventsByDate[date].ToList();
            }

            // Return events for the next 5 days
            List<Event> eventsInRange = new List<Event>();
            for (int i = 0; i < 6; i++) // Check current day and next 5 days
            {
                DateTime checkDate = date.AddDays(i);
                if (eventsByDate.ContainsKey(checkDate))
                {
                    eventsInRange.AddRange(eventsByDate[checkDate]);
                }
            }

            return eventsInRange;
        }

        // Get events by category
        private List<Event> GetEventsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return new List<Event>(); // Return empty if no category selected
            }

            return eventsByDate.Values.SelectMany(queue => queue)
                .Where(e => e.Category == category).ToList();
        }


        // Get events by name
        private List<Event> GetEventsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new List<Event>(); // Return empty if no search term
            }

            return eventsByDate.Values.SelectMany(queue => queue)
                .Where(e => e.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        /// <summary>
        /// Handles the search by category button click event.
        /// </summary>
        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            
            string selectedCategory = comboBoxCategories.SelectedItem?.ToString();

            ShowRecommendations(selectedCategory); // Show recommendations based on selected category

            // Record user search (only category is provided here)
            RecordUserSearch(null, selectedCategory, DateTime.MinValue);
           
        }

        /// <summary>
        /// Handles the clear button click event.
        /// </summary>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            searchTextBox.Text = string.Empty; // Clear search text
        }

    }
}