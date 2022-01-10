library("ggpubr")
library(tidyverse)

Averages <- read.csv("C:/Users/amira/Downloads/Adults - Sheet1 (2).csv")

cor(Averages$Age, Averages$Concentration, method = "pearson", use = "complete.obs")