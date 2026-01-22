window.andonCharts = {};

window.andonCharts.create = (id, labels, values) => {
    const canvas = document.getElementById(id);
    if (!canvas) return;

    const ctx = canvas.getContext('2d');
    if (window.andonCharts[id]) window.andonCharts[id].destroy();

    window.andonCharts[id] = new Chart(ctx, {
        type: "bar",
        data: {
            labels,
            datasets: [{
                data: values,
                borderRadius: 8,
                barThickness: 40,

                backgroundColor: (context) => {
                    const chart = context.chart;
                    const { chartArea } = chart;

                    if (!chartArea) return null;

                    const gradient = chart.ctx.createLinearGradient(
                        0,
                        chartArea.bottom,
                        0,
                        chartArea.top
                    );

                    gradient.addColorStop(0, "#2e7d64"); // dark green (bottom)
                    gradient.addColorStop(1, "#9ccc65"); // light green (top)

                    return gradient;
                }
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            animation: false,
            plugins: {
                legend: { display: false }
            },
            scales: {
                x: {
                    grid: { display: false }
                },
                y: {
                    grid: { color: "#e0e0e0" }
                }
            }
        }
    });
};

window.andonCharts.update = (id, values) => {
    const chart = window.andonCharts[id];
    if (!chart) return;

    chart.data.datasets[0].data = values;
    chart.update("none");
};
