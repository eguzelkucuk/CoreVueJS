const v = new Vue({
    el: '#app',
    data: {
        message: 'Merhaba',
        serverData: [],
        selectData:[]
    },
    created (){
        const that = this;
            $.ajax({
                contentType: "application/json",
                dataType: "json",
                url: "http://localhost:50276/Home/GetProduct",
                method: "GET",
                success: function (response) {
                    that.serverData = response;
                },
                error: function () {
                    console.log("Oops");
                }
            });
    },
    methods: {
        removeSelectItem: function (index) {
            const item = this.selectData.splice(index, 1);
            this.serverData.push(item[0]);
        },
        addSelectItem: function (index) {
            const item = this.serverData.splice(index, 1);
            this.selectData.push(item[0]);
        }
    }
})