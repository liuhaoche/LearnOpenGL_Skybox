#ifndef SHADER_H
#define SHADER_H

#include <glm/glm.hpp>
#include <string>

struct Shader {
    unsigned int ID;

    Shader(const std::string &vertexPath, const std::string &fragmentPath);
    ~Shader();

    void use();

    void setBool(const std::string &name, bool value) const;
    void setInt(const std::string &name, int value) const;
    void setFloat(const std::string &name, float value) const;
    void setMat4(const std::string &name, const glm::mat4 &value) const;
    void setVec3(const std::string &name, const glm::vec3 &value) const;
};

#endif