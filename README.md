# TPBD-lab-project

This project is a Windows Forms Application that manages an Oracle database with the employees of a company.
The actions implemented are:
  * Add employee
  * Modify employee data
  * Delete employee
  * Calculate taxes of employee upon INSERT or UPDATE (DB trigger)
  * Modify amount of taxes (Action protected by encrypted password)
  * Generate reports with selected employees, or all of them
  * Generate payslips for selected employees, or all of them
  * Implemented keypress handlers for all text boxes to allow only specific characters

The environment used when creating this project was a Hyper-V VM with Windows 10 x64 OS.
As of Software:
   * Visual Studio 2015
   * Oracle XE 11g x32
   * ODAC ODP 121024
   * Crystal Report for Visual Studio 13.0.18
