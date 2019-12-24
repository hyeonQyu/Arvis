﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using OpenCvSharp;
//using System;

//public class FingerCount
//{
//    private Scalar _colorBlue;
//    private Scalar _colorGreen;
//    private Scalar _colorRed;
//    private Scalar _colorBlack;
//    private Scalar _colorWhite;
//    private Scalar _colorYellow;
//    private Scalar _colorPurple;

//    public FingerCount()
//    {
//        _colorBlue = new Scalar(255, 0, 0);
//        _colorGreen = new Scalar(0, 255, 0);
//        _colorRed = new Scalar(0, 0, 255);
//        _colorBlack = new Scalar(0, 0, 0);
//        _colorWhite = new Scalar(255, 255, 255);
//        _colorYellow = new Scalar(0, 255, 255);
//        _colorPurple = new Scalar(255, 0, 255);
//    }

//    public Mat FindFingersCount(Mat inputImage, Mat frame)
//    {
//        Mat contoursImage = Mat.Zeros(inputImage.Size(), MatType.CV_8UC3);

//        if(inputImage.Empty())
//            return contoursImage;

//        if(inputImage.Channels() != 1)
//            return contoursImage;

//        Point[][] contours;
//        HierarchyIndex[] hierarchy;

//        Cv2.FindContours(inputImage, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxNone);

//        if(contours.Length <= 0)
//            return contoursImage;

//        // 가장 큰 contour를 찾음(손에서)
//        int biggestContourIndex = -1;
//        double biggestArea = 0.0;

//        for(int i = 0; i < contours.Length; i++)
//        {
//            double area = Cv2.ContourArea(contours[i], false);
//            if(area > biggestArea)
//            {
//                biggestArea = area;
//                biggestContourIndex = i;
//            }
//        }

//        if(biggestContourIndex < 0)
//            return contoursImage;

//        // convex hull을 그리고 경계 사각형을 찾음
//        Point[] hullPoints = Cv2.ConvexHull(contours[biggestContourIndex]);

//        // convex hull 경계
//        OpenCvSharp.Rect boundingRectangle = Cv2.BoundingRect(hullPoints);

//        // 경계 사각형의 중앙을 찾음(손의 중앙으로 가정)
//        Point centerBoundingRect = new Point((boundingRectangle.TopLeft.X + boundingRectangle.BottomRight.X) / 2,
//                                             (boundingRectangle.TopLeft.Y + boundingRectangle.BottomRight.Y) / 2);

//        Point[] startPoints;
//        Point[] farPoints;

//        for(int i = 0; i < defe)
//    }

//    private double FindPointsDistance(Point a, Point b)
//    {

//    }

//    private Point[] CompactOnNeighborhoodMedian(Point[] points, double maxNeighborDistance)
//    {

//    }

//    private double FindAngle(Point a, Point b, Point c)
//    {

//    }

//    private bool IsFinger(Point a, Point b, Point c, double limitAngleInf, double limitAngleSup,
//                                                Point palmCenter, double distanceFromPalmTollerance)
//    {

//    }

//    private Point[] FindClosestOnX(Point[] points, Point pivot)
//    {

//    }

//    private double FindPointsDistanceOnX(Point a, Point b)
//    {

//    }

//    private void DrawVectorPoints(Mat image, Point[] points, Scalar color, bool withNumbers)
//    {

//    }
//}