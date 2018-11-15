<!-- default file list -->
*Files to look at*:

* **[XYSeriesZoomAndRotateAnimation.cs](./CS/XYSeriesCustomAnimationSample/XYSeriesZoomAndRotateAnimation.cs) (VB: [XYSeriesZoomAndRotateAnimation.vb](./VB/XYSeriesCustomAnimationSample/XYSeriesZoomAndRotateAnimation.vb))**
<!-- default file list end -->
# How to: Implement a Custom Series Animation


This example demonstrates how to implement the <strong>Zoom and Rotate</strong> animation for series views supported by the Cartesian (XY) diagram.


<h3>Description</h3>

<p>To implement a custom series animation, create&nbsp;a class derived from&nbsp;the&nbsp;<strong>XYSeriesAnimationBase</strong>&nbsp;class and override the base class&nbsp;<strong>ApplyState&nbsp;</strong>method.<br>The following objects are passed to this method as parameters.<br>- sceneModifier - this object allows you to apply the required transformations to your series.<br>- diagramBounds - this object specifies bounds of the diagram on which an animated series is drawn.<br>- progress - this value specifies the current progress of the animation.</p>

<br/>


