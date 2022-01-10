library("ggpubr")
library(tidyverse)

Final <- read.csv("C:/Users/amira/Downloads/Final Final Averages - Sheet1.csv")

ggplot(data = Final) + 
  geom_point(mapping = aes(x = Age, y = Sensitivity))+
  geom_smooth(mapping = aes(x = Age, y = Sensitivity))
