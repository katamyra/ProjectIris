library("ggpubr")
library(tidyverse)

AdolescentM <- read.csv("C:/Users/amira/Downloads/AdolescentM.csv")
AdultM <- read.csv("C:/Users/amira/Downloads/AdultM.csv")

t.test(AdolescentM$DecisionTime, AdultM$DecisionTime)
