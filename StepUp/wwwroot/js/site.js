// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    // Add the page-transition class to the main content
    const mainContent = document.querySelector('main');
    mainContent.classList.add('page-transition');

    // Add click event listeners to all navigation links
    document.querySelectorAll('a').forEach(link => {
        link.addEventListener('click', function (e) {
            // Only handle internal links
            if (this.href && this.href.startsWith(window.location.origin)) {
                e.preventDefault();
                const targetHref = this.href;

                // Add fade-out class
                mainContent.classList.add('fade-out');

                // Wait for animation to complete before navigating
                setTimeout(() => {
                    window.location.href = targetHref;
                }, 300); // Match this with your CSS transition duration
            }
        });
    });

    // Handle browser back/forward buttons
    window.addEventListener('pageshow', function (event) {
        if (event.persisted) {
            mainContent.classList.remove('fade-out');
        }
    });
});