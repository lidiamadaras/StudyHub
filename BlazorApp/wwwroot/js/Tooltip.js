// tooltip.js
export function initializeCountyTooltips() {
    const tooltip = document.getElementById("tooltip");

    // Attach hover event to counties (update to match your counties' SVG)
    document.querySelectorAll('.county').forEach((county) => {
        county.addEventListener('mouseenter', (event) => {
            const tooltipText = event.target.getAttribute("data-tooltip");
            tooltip.innerText = tooltipText;
            tooltip.style.display = "block";
            tooltip.style.top = `${event.pageY + 5}px`;
            tooltip.style.left = `${event.pageX + 5}px`;
        });

        county.addEventListener('mouseleave', () => {
            tooltip.style.display = "none";
        });
    });
}
