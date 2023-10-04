cmake_minimum_required(VERSION 3.0.0)
project(OpenGL_Project1 VERSION 0.1.0)

include(CTest)
enable_testing()

include_directories(${CMAKE_SOURCE_DIR}/include)
include_directories(${CMAKE_SOURCE_DIR}/src)
link_libraries(${CMAKE_SOURCE_DIR}/lib/glfw3.dll)
link_libraries(${CMAKE_SOURCE_DIR}/lib/libassimp-5.dll)
aux_source_directory(${CMAKE_SOURCE_DIR}/src SRC_FILE)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_SOURCE_DIR}/lib)
add_executable(OpenGL_Project1 ${SRC_FILE})

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)
