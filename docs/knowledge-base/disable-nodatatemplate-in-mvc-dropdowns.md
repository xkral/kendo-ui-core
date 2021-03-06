---
title: Disable noDataTemplate in AutoComplete, MultiSelect, ComboBox, and DropDownList for MVC
description: An example on how to disable the noDataTemplate option in the AutoComplete, MultiSelect, ComboBox, and DropDownList MVC wrappers.
type: how-to
page_title: Disable noDataTemplate in AutoComplete, MultiSelect, ComboBox or DropDownList | Telerik UI for ASP.NET MVC
slug: disable-nodatatemplate-in-mvc-dropdowns
tags: disable, nodatatemplate, mvc, wrappers, autocomplete, multiselect, combobox, dropdownlist
ticketid: 1062781
res_type: kb
---

## Environment

<table>
 <tr>
  <td>Product</td>
  <td>AutoComplete for Progress Kendo UI</td>
 </tr>
</table>

## Description

The `.NoDataTemplate` method of the MVC wrappers for the dropdown widgets&mdash;AutoComplete, MultiSelect, ComboBox, and DropDownList&mdash;accepts only strings as parameters. As a result, the template is not displayed.

## Solution

To disable `noDataTemplate`, set the `noDataTemplate` option of the wrapped widget to `false` after the wrapped widget is initialized.

```html
<script>
$(document).ready(function () {
    var autocomplete = $("#autocomplete").data("kendoAutoComplete");
    autocomplete.setOptions({ noDataTemplate: false });
});
</script>
```
