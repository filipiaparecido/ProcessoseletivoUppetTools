##Usage
Feel free to take it and do whatever you want.
```HTML
<script type="text/javascript" src="jquery.js"></script>
<script src="jquery.checkAll.js" type="text/javascript"></script>
<form action="#">
    <input type="checkbox" name="" id="" class="check-all">
    <input type="checkbox" name="" id="">
    <input type="checkbox" name="" id="">
    <input type="checkbox" name="" id="">
    <input type="checkbox" name="" id="">
    <input type="checkbox" name="" id="">
</form>
<script>
    $(document).ready(function() {
        $(".check-all").checkAll();
    });

</script>
```
By default, The plugin will select closest form element.

You can provide a selector to select specific scope:

```HTML
<form action="#">
  <fieldset>
      <input type="checkbox" name="" id="" class="check-all">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
  </fieldset>
</form>
<form action="#">
  <fieldset>
      <input type="checkbox" name="" id="" class="check-all">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
      <input type="checkbox" name="" id="">
  </fieldset>
</form>
<script>
  $(document).ready(function() {
      $(".check-all").checkAll({
          scope: 'fieldset'
      });
  });
</script>
```
Also you can provide a Jquery object to select a specific scope

```HTML
<div class="control-panel">
    <input type="checkbox" name="" id="" class="check-all">
</div>
<form action="#" id="submit-form">
    <fieldset>
        <label for="">First Name:</label>
        <input type="text" name="" id="">
        <label for="">Last Name</label>
        <input type="text" name="" id="">
    </fieldset>
    <fieldset id="categories">
        <legend>Category</legend>
        <label><input type="checkbox" name="" id=""></label>
        <label><input type="checkbox" name="" id=""></label>
        <label><input type="checkbox" name="" id=""></label>
        <label><input type="checkbox" name="" id=""></label>
        <label><input type="checkbox" name="" id=""></label>
        <label><input type="checkbox" name="" id=""></label>
    </fieldset>
</form>
<script>
    $(document).ready(function() {
        $(".check-all").checkAll({
            scope : $('#categories')
        });
    });
</script>
```
##Options and Callback
```HTML
<script>
    $(".check-all").checkAll({
        scope : $('#categories'),
        onMasterClick: function($master_checkbox, $scope) {
                //do something...
        },
        onScopeChange: function($master_checkbox, $changed_checkbox, $scope) {
            //do something...
        }
    });
</script>
```
