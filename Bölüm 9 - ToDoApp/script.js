var items = ['item 1', 'item 2', 'item 3', 'item 4'];

var list = document.querySelector('#myList');


items.forEach(function(item) {
    createItem(item);
});


list.addEventListener('click', function (item) {
    if (item.target.tagName = 'li') {
        item.target.classList.toggle('checked');
    }


});

document.querySelector('#btn-create').onclick=function(){
    
    var item = document.querySelector('#txt-item').value;
    if(item==''){
        alert('Lütfen bir değer giriniz.');
        return;
    }
    createItem(item);
};



function createItem(item){
    var li = document.createElement('li');
    var t = document.createTextNode(item);

    li.className = 'list-group-item';
    li.appendChild(t);

    list.appendChild(li);

    var span = document.createElement('span');
    var text = document.createTextNode('x');
    span.className = 'close';
    span.appendChild(text);
    li.appendChild(span);


    span.onclick = function () {
        var li = this.parentElement;
        li.style.display = 'none';
    }
}









