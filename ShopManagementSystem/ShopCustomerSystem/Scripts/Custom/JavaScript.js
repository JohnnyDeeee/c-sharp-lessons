function OrderList(property, order) {
    $.ajax({
        url: window.applicationBaseUrl + '/Items/GetItemsOrdered/'+property+'/'+order,
        type: 'GET',
        success: function (data) {
            console.log("succes message: ", data);
            
            RePopulateList(data);

            // Change order type for next click
            var nextOrderType = order == 'asc' ? 'desc' : 'asc';
            $("#"+property+"OrderLink").attr('onClick', 'OrderList("'+property+'", "' + nextOrderType + '")');
        },
        error: function (data) {
            console.log("error message: ", data);
        }
    })
}

function SearchList(e) {
    if (e.which != 13) // 13 = enter key
        return;

    console.log("log");
    $.ajax({
        url: window.applicationBaseUrl + '/Items/GetItemsFromSearch/'+$(e.target).val(),
        type: 'GET',
        success: function (data) {
            console.log("succes message: ", data);

            RePopulateList(data);
        },
        error: function (data) {
            console.log("error message: ", data);
        }
    })
}

function AddToCart(itemId)
{
    // Add item to session with ajax
    $.ajax({
        url: window.applicationBaseUrl + '/Items/AddItemToCart/'+itemId,
        type: 'POST',
        success: function (data) {
            //console.log("succes message: ", data);
            toastr.success("Item has been added to your shopping cart! <br><br><u><a href='/ShoppingCart'>Go to my shopping cart</a></u>");
        },
        error: function (data) {
            //console.log("error message: ", data);
            toastr.error("Could not add this item to your shopping cart, please try again later...");
        }
    })
}




// Private functions
function RePopulateList(data)
{
    // Remove old data
    $(".itemRow").each(function () {
        $(this).remove();
    });

    // Update table (id=list) with the new data
    for (var i = 0; i < data.length; i++) {
        var newRowData = "<td>" + data[i].Name + "</td>";
        newRowData += "<td>" + data[i].Price + "</td>";
        newRowData += "<td>" + data[i].Description + "</td>";
        newRowData += "<td>" + data[i].Stock + "</td>";
        newRowData += "<td>" + data[i].Category.Name + "</td>";
        newRowData += "<td>" + data[i].Supplier.Name + "</td>";
        // TODO: Add order link

        var newRow = "<tr class='itemRow'>" + newRowData + "</tr>";

        $("#list").append(newRow);
    }
}
