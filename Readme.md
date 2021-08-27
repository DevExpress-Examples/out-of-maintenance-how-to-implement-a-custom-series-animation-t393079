<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574838/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T393079)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[XYSeriesZoomAndRotateAnimation.cs](./CS/XYSeriesCustomAnimationSample/XYSeriesZoomAndRotateAnimation.cs) (VB: [XYSeriesZoomAndRotateAnimation.vb](./VB/XYSeriesCustomAnimationSample/XYSeriesZoomAndRotateAnimation.vb))**
<!-- default file list end -->
# How to: Implement a Custom Series Animation


This example demonstrates how to implement the <strong>Zoom and Rotate</strong> animation for series views supported by the Cartesian (XY) diagram.


<h3>Description</h3>

<p>To implement a custom series animation, create&nbsp;a class derived from&nbsp;the&nbsp;<strong>XYSeriesAnimationBase</strong>&nbsp;class and override the base class&nbsp;<strong>ApplyState&nbsp;</strong>method.<br>The following objects are passed to this method as parameters.<br>- sceneModifier - this object allows you to apply the required transformations to your series.<br>- diagramBounds - this object specifies bounds of the diagram on which an animated series is drawn.<br>- progress - this value specifies the current progress of the animation.</p>

<br/>


