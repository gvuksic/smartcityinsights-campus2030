# smartcityinsights-campus2030
Smart City Insights project

## Inspiration
We live in an age of Big data and AI. Almost everything around us is captured digitally or is connected to a data source in some way. AI is developing rapidly like no other technology so far and it is already used in many ways that improve our lives. It is changing the way doctors treat diseases, it is helping people with disabilities, helping us in fight with climate change, and so on.

Smart cities need to build data driven solutions that will use AI in order to improve their resident lives. Imagine we could understand what is happening in the city in the real time, how many pedestrians, cars or bicycles are on the streets. Such data driven solution would help us build smart city infrastructure.

## What it does
Smart cities need insights into the real-time movement data. Multiple public service (such as police, firefighters, road maintenance and others) have needs to understand what is happening in the real-time. This insights can support smart city infrastructure development in mobility, sustainability, public safety and many other aspects.

## How we built it
Our solution “Smart City Insights” use existing public transport infrastructure and available cameras on the busses. Data from cameras video feed is processed “on the edge” with device NVIDIA Jetson Nano, which is capable of processing AI object detection algorithms. Algorithms can detect many different object categories with standard recognition in the video feed: people, cars, motorcycles, bicycles and many other. All data is anonymized and only data points are uploaded to the cloud which allows this solution to work on low bandwidth. Insights are presented in the dashboard and can easily be configured to send notifications about different anomalies to relevant public services.

## Solution benefits
Smart City Insights solution provides awareness about unexpected events that can happen and are relevant for rapid reaction, like detection of firearms in the crowd on which police should react immediately or detection of fire for firefighters to be notified on time. Modality awareness allow us to plan actions in the city like closing some road for car traffic to high density of bicycles, or it can also suggest people where is best to travel with bicycles. Density awareness can alert relevant public services in cases of protest, riots, or about overcrowded places in case of virus restrictions.

## Accomplishments that we are proud of
We are proud that in such limited amount of time we managed to build proof of concept for this solution that can truly help cities to become smart. It was really interesting project to work on and we enjoyed it.

## What's next for Smart City Insights
Smart City Insights solution should be connected to the smart building and other IoT data sources to gain insights from the smart buildings and connect this data with existing movement insights. Smart city often have underground train or metro which infrastructure is tightly connected with city infrastructure and can provide valuable insights. Data from the many other sources (weather, roads, satellite…) can be connected to the solution and provide even more insights needed to build infrastructure for real smart cities.