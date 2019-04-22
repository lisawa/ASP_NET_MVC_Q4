function getSubDeptList(dID) {
    $.ajax({
        url: '/Dept/GetDropDown/' + dID,
        type: 'GET',
        success: function (res) {
            $("#subDept option").remove();
            $.each(res, function () {
                $("#subDept").append($("<option></option>").attr("value", this.Id).text(this.Name));
            })
        },
        error: function (res) {
            console.log(res);
        }
    });
}

function SubmitDpet() {
    $('#submitResult').text($('#dept option:selected').text() + ' - ' + $('#subDept option:selected').text());
}

window.onload = function () {
    getSubDeptList($('#dept option:selected').val());
    new Vue({
        el: '#app',
        data: {
            options: [],
            submitValue: '',
            selectSub: {}
        },
        methods: {
            change: function($event) {
                var vm = this;
                console.log($event.target.value);
                $.ajax({
                    url: '/Dept/GetDropDown/' + $event.target.value,
                    type: 'GET',
                    success: function (res) {
                        vm.options = res;
                        vm.selectSub = res[0];
                    },
                    error: function (res) {
                        console.log(res);
                    }
                });
            },
            SubmitDpetVue: function () {
                this.submitValue = $('#deptVue option:selected').text() + ' - ' + this.selectSub.Name;
                console.log(this.selectSub);
            }
        },
        beforeMount() {
            var vm = this;
            $.ajax({
                url: '/Dept/GetDropDown/1',
                type: 'GET',
                success: function (res) {
                    vm.options = res;
                    vm.selectSub = res[0];
                },
                error: function (res) {
                    console.log(res);
                }
            });
        },
    })
}