<h1> Report Tracking System</h1>
<h2> Purpose:</h2> A simple Windows Forms desktop application designed for administrators to manage issue reports submitted by employees.
The goal of this application is to streamline the tracking and management of workplace issue reports through an intuitive interface. It enables the creation, updating, searching, sorting, saving, and exporting of reports.

<h2>Features:</h2>
<h3> 1. Create Reports:</h3>
- Input fields: 'Title', 'Description', 'Reported By' </br>
- Automatically generate a Report ID in the format: `RPT-001`, `RPT-002`, etc.</br>
- Auto-fill 'Date Reported' with the current date </br>
- Default 'Status': `Pending` </br>
- Add new reports to a ListView

<h3> 2. View All Reports:</h3>
- Display all reports in a ListView showing:</br>
  - Report ID</br>
  - Title</br>
  - Description</br>
  - Reported By</br>
  - Status</br>
  - Date Reported

<h3> 3. Update Report Status:</h3>
- Select a report from the ListView</br>
- Use a ComboBox to change the status:</br>
  - `Pending`</br>
  - `In Progress`</br>
  - `Resolved`</br>
  - `Closed`</br>
- Click an Update button to apply changes

<h3> 4. Search for Reports:</h3>
- Enter a Report ID into a TextBox </br>
- Click a 'Search' button to find and highlight the matching report

<h3>5. Save Reports to File:</h3>
- Save all reports to a CSV file when the application is closed

<h3> 6. Load Reports on Startup:</h3>
- Load saved reports from the CSV file into the ListView when the app starts

<h2> Additional Features:</h2>
- Sort reports by:</br>
  - `Status`</br>
  - `Date Reported`</br>
- Delete a selected report</br>
- Export all reports to a PDF document



