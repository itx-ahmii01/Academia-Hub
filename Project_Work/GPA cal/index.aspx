<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Project_Work.GPA_cal.index" %>

<!DOCTYPE html>
<html>
<head>
    <title>Responsive Website Using Tailwind Css </title>
    <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet">

</head>
<body>

    <header class="text-gray-400 bg-gray-900 body-font">
        <div class="container mx-auto flex flex-wrap p-5 flex-col md:flex-row items-center">
            <a href="\WebForms\homepage.aspx" class="flex title-font font-medium items-center text-white mb-4 md:mb-0">
                <svg xmlns="http://www.w3.org/2000/svg"
                     class="fill-current text-blue-500  h-16 w-16"
                     fill="none" viewBox="0 0 24 24" stroke="currentColor">
                    <path stroke-linecap="round" stroke-linejoin="round"
                          stroke-width="2"
                          d="M3 12l2-2m0 0l7-7 7 7M5 10v10a1 1 0 001 1h3m10-11l2
                 2m-2-2v10a1 1 0 01-1 1h-3m-6 0a1 1 0 001-1v-4a1
                 1 0 011-1h2a1 1 0 011 1v4a1 1 0 001 1m-6 0h6" />
                </svg>
                <span class="ml-3 text-xl">Academia Community</span>
            </a>
            <nav class="md:ml-auto md:mr-auto flex flex-wrap items-center text-base justify-center">
      <a href="\WebForms\feedback.aspx" class="mr-5 hover:text-white">FeedBack</a>
      <a href="\WebForms\faqs.aspx" class="mr-5 hover:text-white">FAQ's</a>
      <a href="\WebForms\ContactUs.aspx" class="mr-5 hover:text-white">Contact Us</a>

            </nav>
            <button class="inline-flex items-center bg-blue-800 text-white border-0 py-1 px-3 focus:outline-none hover:bg-gray-700 rounded text-base mt-4 md:mt-0">
                <a href="\WebForms\profile.aspx" >Profile</a>
                <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-4 h-4 ml-1" viewBox="0 0 24 24">
                    <path d="M5 12h14M12 5l7 7-7 7"></path>
                </svg>
            </button>
        </div>
    </header>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>GPA Calculator</title>
        <link rel="stylesheet" href="bootstrap.css">
        <link rel="stylesheet" href="styles.css">
    </head>
    <body>
        <div class="wrapper">
            <h1>GPA Calculator</h1>
            <div class="form-row">
                <div class="col">
                    <input id="course-code" class="form-control" type="text" placeholder="Course Code">
                </div>
                <div class="col">
                    <input id="unit-load" class="form-control" type="number" placeholder="Credit-Hour" min="1" max="4">
                </div>
                <div class="col">
                    <select id="grade" class="form-control">
                        <option value="">Grade</option>
                        <option value="4.00">A+</option>
                        <option value="4.00">A</option>
                        <option value="3.67">A-</option>
                        <option value="3.33">B+</option>
                        <option value="3.00">B</option>
                        <option value="2.67">B-</option>
                        <option value="2.33">C+</option>
                        <option value="2.00">C</option>
                        <option value="1.67">C-</option>
                        <option value="1.33">D+</option>
                        <option value="1.00">D</option>
                        <option value="0">F</option>
                    </select>
                </div>
                <div class="col">
                    <input id="add" class="btn btn-primary" type="button" value="Add">

                </div>
            </div>
            <table id="table" class="table table-bordered display-none">
                <thead>
                    <tr>
                        <th>Course Code</th>
                        <th>Credit-Hour</th>
                        <th>Grade</th>
                    </tr>
                </thead>
                <tbody id="tbody"></tbody>
                <tfoot id="tfoot">

                </tfoot>
            </table>
            <div class="row">
                <div class="col">
                    <input id="calc-gp" class="btn btn-success display-none" type="button" value="Calc GPA">
                </div>
                <div class="col">
                    <input id="clear" class="btn btn-warning display-none" type="button" value="Clear">
                </div>
            </div>
        </div>
        <script src="main.js"></script>
    </body>
    <footer class="text-gray-400 bg-gray-900 body-font">
        <div class="container px-5 py-8 mx-auto flex items-center sm:flex-row flex-col">
            <a class="flex title-font font-medium items-center md:justify-start justify-center text-white">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-10 h-10 text-white p-2 bg-indigo-500 rounded-full" viewBox="0 0 24 24">
                    <path d="M12 2L2 7l10 5 10-5-10-5zM2 17l10 5 10-5M2 12l10 5 10-5"></path>
                </svg>
                <span class="ml-3 text-xl">Academia Hub</span>
            </a>
            <p class="text-sm text-gray-400 sm:ml-4 sm:pl-4 sm:border-l-2 sm:border-gray-800 sm:py-2 sm:mt-0 mt-4">
                ©️ 2021 Academia Hub —
                <a href="https://twitter.com/knyttneve" class="text-gray-500 ml-1" target="_blank" rel="noopener noreferrer">@malikahmad_ahmii</a>
            </p>
            <span class="inline-flex sm:ml-auto sm:mt-0 mt-4 justify-center sm:justify-start">
                <a class="text-gray-400">
                    <svg fill="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-5 h-5" viewBox="0 0 24 24">
                        <path d="M18 2h-3a5 5 0 00-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 011-1h3z"></path>
                    </svg>
                </a>
                <a class="ml-3 text-gray-400">
                    <svg fill="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-5 h-5" viewBox="0 0 24 24">
                        <path d="M23 3a10.9 10.9 0 01-3.14 1.53 4.48 4.48 0 00-7.86 3v1A10.66 10.66 0 013 4s-4 9 5 13a11.64 11.64 0 01-7 2c9 5 20 0 20-11.5a4.5 4.5 0 00-.08-.83A7.72 7.72 0 0023 3z"></path>
                    </svg>
                </a>
                <a class="ml-3 text-gray-400">
                    <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-5 h-5" viewBox="0 0 24 24">
                        <rect width="20" height="20" x="2" y="2" rx="5" ry="5"></rect>
                        <path d="M16 11.37A4 4 0 1112.63 8 4 4 0 0116 11.37zm1.5-4.87h.01"></path>
                    </svg>
                </a>
                <a class="ml-3 text-gray-400">
                    <svg fill="currentColor" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="0" class="w-5 h-5" viewBox="0 0 24 24">
                        <path stroke="none" d="M16 8a6 6 0 016 6v7h-4v-7a2 2 0 00-2-2 2 2 0 00-2 2v7h-4v-7a6 6 0 016-6zM2 9h4v12H2z"></path>
                        <circle cx="4" cy="4" r="2" stroke="none"></circle>
                    </svg>
                </a>
            </span>
        </div>
    </footer>
</html>

