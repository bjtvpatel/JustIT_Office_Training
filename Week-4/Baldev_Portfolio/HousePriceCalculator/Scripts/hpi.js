$.getJSON('~\Data/ukhpi-harrow-from-january-2005-to-april-2017.json', function (data) {
    destinations = data['items']

    $.each(destinations, function (id, destination) {
        destination = destination["ukhpi:refMonth"]
    })
}
    );