function OrderList(property, order) {
    $.ajax({
        url: window.applicationBaseUrl + 'api/Items/GetItemsOrdered',
        type: 'GET',
        data: { property: property, order: order },
        success: function (data) {
            console.log("succes message: ", data);
            // TODO: Update table (id=list) with the new data
            var newContent = "";
            $.each(data, function (index, element) {
                newContent += "<tr>"+element["Price"]+"</tr>";
            });
            $("#list > tbody").html(newContent);
        },
        error: function (data) {
            console.log("error message: ", data);
        }
    })
}